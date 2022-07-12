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
	public partial class Create_employee : Form
	{
		private Form previous_form;
		private SqlConnection sqlConnection = null;

		public Create_employee(Form temp)
		{
			previous_form = temp;
			InitializeComponent();
		}

		private void Create_employee_FormClosing(object sender, FormClosingEventArgs e)
		{
			previous_form.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand command = new SqlCommand(
				$"INSERT INTO [employees] (name, surname, patronymic, phone, adress, department_id, position_id, salary, premium_id) VALUES (@name, @surname, @patronymic, @phone, @adress, (SELECT id FROM [department] WHERE name = @department_id), (SELECT id FROM [positions] WHERE name = @position_id), @salary, (SELECT id FROM [kpi] WHERE mark = @premium_id))",
				sqlConnection);

				command.Parameters.AddWithValue("name", textBox1.Text);
				command.Parameters.AddWithValue("surname", textBox2.Text);
				command.Parameters.AddWithValue("patronymic", textBox3.Text);
				command.Parameters.AddWithValue("phone", textBox4.Text);
				command.Parameters.AddWithValue("adress", textBox5.Text);
				command.Parameters.AddWithValue("department_id", comboBox3.Text);
				command.Parameters.AddWithValue("position_id", comboBox2.Text);
				command.Parameters.AddWithValue("salary", textBox8.Text);
				command.Parameters.AddWithValue("premium_id", comboBox1.Text);

				command.ExecuteNonQuery();

				MessageBox.Show("Содрудник успешно создан.");
				this.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Данные введены неверно.");
			}
		}

		private void Create_employee_Load(object sender, EventArgs e)
		{
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDB"].ConnectionString);

			sqlConnection.Open();

			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT name FROM [department]", sqlConnection);

			DataSet departments = new DataSet();
			dataAdapter.Fill(departments);
			comboBox3.DataSource = departments.Tables[0];
			comboBox3.DisplayMember = "name";
			comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

			dataAdapter.SelectCommand.CommandText = "SELECT name FROM [positions]";
			DataSet positions = new DataSet();
			dataAdapter.Fill(positions);
			comboBox2.DataSource = positions.Tables[0];
			comboBox2.DisplayMember = "name";
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

			dataAdapter.SelectCommand.CommandText = "SELECT mark FROM [kpi]";
			DataSet marks = new DataSet();
			dataAdapter.Fill(marks);
			comboBox1.DataSource = marks.Tables[0];
			comboBox1.DisplayMember = "mark";
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}
	}
}
