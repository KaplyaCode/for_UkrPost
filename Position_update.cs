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
	public partial class Position_update : Form
	{
		private SqlConnection sqlConnection = null;
		SQLInspector SQLInspector = new SQLInspector();
		public Position_update()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataSet dataSet = SQLInspector.RefreshRef(sqlConnection, "positions");
			dataGridView1.DataSource = dataSet.Tables[0];
		}

		private void Position_update_Load(object sender, EventArgs e)
		{
			sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeesDB"].ConnectionString);

			sqlConnection.Open();

			button1_Click(sender, e);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SQLInspector.INSERT(sqlConnection, textBox1, "positions");
			button1_Click(sender, e);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Удаление отдела приведет к удалению всех сотрудников из этого отдела", "Предупреждение", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				SQLInspector.DELETE(sqlConnection, dataGridView1, "positions");
				button1_Click(sender, e);
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SQLInspector.UPDATE(sqlConnection, dataGridView1, textBox1, "positions");
			button1_Click(sender, e);
		}
	}
}
