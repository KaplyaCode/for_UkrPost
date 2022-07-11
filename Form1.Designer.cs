
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.редактированиеОтделовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.редактированиеДолжностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавлениеСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
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
			// редактированиеОтделовToolStripMenuItem
			// 
			this.редактированиеОтделовToolStripMenuItem.Name = "редактированиеОтделовToolStripMenuItem";
			this.редактированиеОтделовToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
			this.редактированиеОтделовToolStripMenuItem.Text = "Редактирование отделов";
			// 
			// редактированиеДолжностейToolStripMenuItem
			// 
			this.редактированиеДолжностейToolStripMenuItem.Name = "редактированиеДолжностейToolStripMenuItem";
			this.редактированиеДолжностейToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
			this.редактированиеДолжностейToolStripMenuItem.Text = "Редактирование должностей";
			// 
			// добавлениеСотрудниковToolStripMenuItem
			// 
			this.добавлениеСотрудниковToolStripMenuItem.Name = "добавлениеСотрудниковToolStripMenuItem";
			this.добавлениеСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
			this.добавлениеСотрудниковToolStripMenuItem.Text = "Добавление сотрудника";
			this.добавлениеСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.добавлениеСотрудникаToolStripMenuItem_Click);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 523);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem редактированиеОтделовToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem редактированиеДолжностейToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem добавлениеСотрудниковToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выплатыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
	}
}

