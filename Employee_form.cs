using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace UkrPost
{
	public partial class Employee_form : Form
	{
		private SqlConnection sqlConnection = null;
		private int chosen_employee;

		public Employee_form(int temp)
		{
			InitializeComponent();
			chosen_employee = temp;
		}

		private void Employee_form_Load(object sender, EventArgs e)
		{
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDB"].ConnectionString);

			sqlConnection.Open();

			SqlDataAdapter dataAdapter = new SqlDataAdapter(
				$"SELECT employees.*, employees.name AS 'name', [kpi].mark AS 'mark', [department].name AS 'department', [positions].name AS 'positions' FROM employees, positions, department, kpi WHERE department.id = department_id AND premium_id = kpi.id AND positions.Id = position_id AND employees.id = {chosen_employee}", sqlConnection);

			DataSet dataSet = new DataSet();

			dataAdapter.Fill(dataSet);

			textBox1.Text = dataSet.Tables[0].Rows[0].Field<string>("name");
			textBox2.Text = dataSet.Tables[0].Rows[0].Field<string>("surname");
			textBox3.Text = dataSet.Tables[0].Rows[0].Field<string>("patronymic");
			textBox4.Text = dataSet.Tables[0].Rows[0].Field<string>("phone");
			textBox5.Text = dataSet.Tables[0].Rows[0].Field<string>("adress");
			label10.Text = dataSet.Tables[0].Rows[0].Field<string>("department");

			dataAdapter.SelectCommand.CommandText = "SELECT name FROM [department]";
			DataSet departments = new DataSet();
			dataAdapter.Fill(departments);
			comboBox3.DataSource = departments.Tables[0];
			comboBox3.DisplayMember = "name";
			comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

			label11.Text = dataSet.Tables[0].Rows[0].Field<string>("positions");

			dataAdapter.SelectCommand.CommandText = "SELECT name FROM [positions]";
			DataSet positions = new DataSet();
			dataAdapter.Fill(positions);
			comboBox2.DataSource = positions.Tables[0];
			comboBox2.DisplayMember = "name";
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

			textBox8.Text = dataSet.Tables[0].Rows[0].Field<decimal>("salary").ToString("G");
			label12.Text = dataSet.Tables[0].Rows[0].Field<string>("mark");

			dataAdapter.SelectCommand.CommandText = "SELECT mark FROM [kpi]";
			DataSet marks = new DataSet();
			dataAdapter.Fill(marks);
			comboBox1.DataSource = marks.Tables[0];
			comboBox1.DisplayMember = "mark";
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand(
				"UPDATE [employees] SET name = @NAME, surname = @SURNAME, patronymic = @PATRONYMIC, phone = @PHONE, adress = @ADRESS, department_id = (SELECT id FROM [department] WHERE name = @DEPARTMENT), position_id = (SELECT Id FROM [positions] WHERE name = @POSITION), salary = @SALARY, premium_id = (SELECT Id FROM [kpi] WHERE mark = @PREMIUM) WHERE ID = @selected_id",
				sqlConnection);

			command.Parameters.AddWithValue("NAME", textBox1.Text);
			command.Parameters.AddWithValue("SURNAME", textBox2.Text);
			command.Parameters.AddWithValue("PATRONYMIC", textBox3.Text);
			command.Parameters.AddWithValue("PHONE", textBox4.Text);
			command.Parameters.AddWithValue("ADRESS", textBox5.Text);
			command.Parameters.AddWithValue("DEPARTMENT", comboBox3.Text);
			command.Parameters.AddWithValue("POSITION", comboBox2.Text);
			command.Parameters.AddWithValue("SALARY", float.Parse(textBox8.Text));
			command.Parameters.AddWithValue("PREMIUM", comboBox1.Text);
			command.Parameters.AddWithValue("selected_id", chosen_employee);

			command.ExecuteNonQuery();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand(
				$"DELETE FROM [employees] WHERE ID = @selected_id",
				sqlConnection);

			command.Parameters.AddWithValue("selected_id", chosen_employee);

			command.ExecuteNonQuery();
			this.Close();
		}
	}
}
