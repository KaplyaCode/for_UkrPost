using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace UkrPost
{
	class SQLInspector
	{
		public DataSet RefreshMainDataGrid(SqlConnection sqlConnection)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter(
				   "SELECT [employees].id AS 'ID', [employees].name AS 'Name', [surname] AS 'Surname', [patronymic] AS 'Patronymic', [department].name AS Department, [positions].name AS Position, [salary] AS 'Salary', [kpi].mark AS 'Premium' FROM employees, positions, department, kpi WHERE premium_id = kpi.id AND department.id = department_id AND positions.Id = position_id", sqlConnection);

			DataSet dataSet = new DataSet();

			dataAdapter.Fill(dataSet);

			return dataSet;
		}

		public DataSet RefreshRef(SqlConnection sqlConnection, string table)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter(
				  $"SELECT * FROM [{table}]", sqlConnection);

			DataSet dataSet = new DataSet();

			dataAdapter.Fill(dataSet);

			return dataSet;
		}

		public void INSERT(SqlConnection sqlConnection, TextBox textBox,  string table)
		{
			SqlCommand command = new SqlCommand(
				$"INSERT INTO [{table}] (name) VALUES (@name)",
				sqlConnection);

			command.Parameters.AddWithValue("name", textBox.Text);

			command.ExecuteNonQuery();
		}

		public void DELETE(SqlConnection sqlConnection, DataGridView dataGridView, string table)
		{
			SqlCommand command = new SqlCommand(
				$"DELETE FROM [{table}] WHERE ID = @selected_id",
				sqlConnection);

			command.Parameters.AddWithValue("selected_id", Int32.Parse(dataGridView.SelectedCells[0].Value.ToString()));

			command.ExecuteNonQuery();
		}

		public void UPDATE(SqlConnection sqlConnection, DataGridView dataGridView, TextBox textBox, string table)
		{
			SqlCommand command = new SqlCommand(
				$"UPDATE [{table}] SET name = @new_name WHERE ID = @selected_id",
				sqlConnection);

			command.Parameters.AddWithValue("new_name", textBox.Text);
			command.Parameters.AddWithValue("selected_id", Int32.Parse(dataGridView.SelectedCells[0].Value.ToString()));

			command.ExecuteNonQuery();
		}

	}
}
