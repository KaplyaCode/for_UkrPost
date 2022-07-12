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
	public partial class Payments_form : Form
	{
		Form previous_form;
		private SqlConnection sqlConnection = null;
		private SQLInspector SQLInspector = new SQLInspector();

		public Payments_form(Form temp_form)
		{
			InitializeComponent();
			previous_form = temp_form;
		}

		private void Payments_form_Load(object sender, EventArgs e)
		{
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDB"].ConnectionString);

			sqlConnection.Open();

			button2_Click(sender, e);
		}

		private void Payments_form_FormClosing(object sender, FormClosingEventArgs e)
		{
			previous_form.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter(
				$"SELECT [employees].id AS 'ID', [employees].name AS 'Name', [surname] AS 'Surname', [patronymic] AS 'Patronymic', [department].name AS Department, [positions].name AS Position, [salary] AS 'Salary', [kpi].mark AS 'Premium' FROM employees, positions, department, kpi WHERE premium_id = kpi.id AND department.id = department_id AND department.name = '{comboBox1.Text}' AND positions.Id = position_id", sqlConnection);

			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet.Tables[0];

			dataAdapter.SelectCommand.CommandText = $"SELECT SUM(salary) FROM [employees], [department] WHERE department_id = [department].id AND [department].name = '{comboBox1.Text}'";
			DataSet summ = new DataSet();

			dataAdapter.Fill(summ);
			try
			{
				label3.Text = summ.Tables[0].Rows[0].Field<decimal>("Column1").ToString("G");
			}
			catch (Exception)
			{
				label3.Text = "0";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DataSet dataSet = SQLInspector.RefreshMainDataGrid(sqlConnection);

			dataGridView1.DataSource = dataSet.Tables[0];

			dataGridView1.DataSource = dataSet.Tables[0];

			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT SUM(salary) FROM [employees]", sqlConnection);
			DataSet summ = new DataSet();

			dataAdapter.Fill(summ);

			label3.Text = summ.Tables[0].Rows[0].Field<decimal>("Column1").ToString("G");

			dataAdapter.SelectCommand.CommandText = "SELECT name FROM [department]";
			DataSet departments = new DataSet();
			dataAdapter.Fill(departments);
			comboBox1.DataSource = departments.Tables[0];
			comboBox1.DisplayMember = "name";
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}
	}
}
