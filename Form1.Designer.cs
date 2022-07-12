
namespace UkrPost
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.редактированиеОтделовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактированиеДолжностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавлениеСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.button2);
			this.splitContainer1.Panel1.Controls.Add(this.button1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer1.Size = new System.Drawing.Size(927, 499);
			this.splitContainer1.SplitterDistance = 83;
			this.splitContainer1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(382, 11);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(141, 58);
			this.button2.TabIndex = 3;
			this.button2.Text = "Без фильтра";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(235, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 58);
			this.button1.TabIndex = 2;
			this.button1.Text = "Фильтровать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выберите отдел";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(16, 37);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(213, 32);
			this.comboBox1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(927, 412);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// редактированиеОтделовToolStripMenuItem
			// 
			this.редактированиеОтделовToolStripMenuItem.Name = "редактированиеОтделовToolStripMenuItem";
			this.редактированиеОтделовToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
			this.редактированиеОтделовToolStripMenuItem.Text = "Редактирование отделов";
			this.редактированиеОтделовToolStripMenuItem.Click += new System.EventHandler(this.редактированиеОтделовToolStripMenuItem_Click);
			// 
			// редактированиеДолжностейToolStripMenuItem
			// 
			this.редактированиеДолжностейToolStripMenuItem.Name = "редактированиеДолжностейToolStripMenuItem";
			this.редактированиеДолжностейToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
			this.редактированиеДолжностейToolStripMenuItem.Text = "Редактирование должностей";
			this.редактированиеДолжностейToolStripMenuItem.Click += new System.EventHandler(this.редактированиеДолжностейToolStripMenuItem_Click);
			// 
			// добавлениеСотрудниковToolStripMenuItem
			// 
			this.добавлениеСотрудниковToolStripMenuItem.Name = "добавлениеСотрудниковToolStripMenuItem";
			this.добавлениеСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
			this.добавлениеСотрудниковToolStripMenuItem.Text = "Добавление сотрудника";
			// 
			// выплатыToolStripMenuItem
			// 
			this.выплатыToolStripMenuItem.Name = "выплатыToolStripMenuItem";
			this.выплатыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.выплатыToolStripMenuItem.Text = "Выплаты";
			// 
			// отчетToolStripMenuItem
			// 
			this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
			this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.отчетToolStripMenuItem.Text = "Отчет";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеОтделовToolStripMenuItem,
            this.редактированиеДолжностейToolStripMenuItem,
            this.добавлениеСотрудниковToolStripMenuItem,
            this.выплатыToolStripMenuItem,
            this.отчетToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(927, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 523);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ToolStripMenuItem редактированиеОтделовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редактированиеДолжностейToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавлениеСотрудниковToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

