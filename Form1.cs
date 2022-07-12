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
	public partial class Form1 : Form
	{
		private SqlConnection sqlConnection = null;
		SQLInspector SQLInspector = new SQLInspector();

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDB"].ConnectionString);

			sqlConnection.Open();

			DataSet dataSet = SQLInspector.RefreshMainDataGrid(sqlConnection);

			dataGridView1.DataSource = dataSet.Tables[0];

			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT name FROM [department]", sqlConnection);
			DataSet departments = new DataSet();
			dataAdapter.Fill(departments);
			comboBox1.DataSource = departments.Tables[0];
			comboBox1.DisplayMember = "name";
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter(
				$"SELECT [employees].id AS 'ID', [employees].name AS 'Name', [surname] AS 'Surname', [patronymic] AS 'Patronymic', [department].name AS Department, [positions].name AS Position, [salary] AS 'Salary', [kpi].mark AS 'Premium' FROM employees, positions, department, kpi WHERE premium_id = kpi.id AND department.id = department_id AND department.name = '{comboBox1.Text}' AND positions.Id = position_id", sqlConnection);

			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet);

			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void button2_Click(object sender, EventArgs e)
		{		
			DataSet dataSet = SQLInspector.RefreshMainDataGrid(sqlConnection);

			dataGridView1.DataSource = dataSet.Tables[0];
		}

		Employee_form employee_form;

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			employee_form = new Employee_form(Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString()), this);
			employee_form.Show();
			this.Hide();
		}

		Departmens_update departmens_Update;

		private void редактированиеОтделовToolStripMenuItem_Click(object sender, EventArgs e)
		{
			departmens_Update = new Departmens_update(this);
			departmens_Update.Show();
			this.Hide();
		}

		Position_update position_Update;

		private void редактированиеДолжностейToolStripMenuItem_Click(object sender, EventArgs e)
		{
			position_Update = new Position_update(this);
			position_Update.Show();
			this.Hide();
		}

		Create_employee create_Employee;

		private void добавлениеСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
		{
			create_Employee = new Create_employee(this);
			create_Employee.Show();
			this.Hide();
		}

		Payments_form payments_Form;

		private void выплатыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			payments_Form = new Payments_form(this);
			payments_Form.Show();
			this.Hide();
		}

		private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
