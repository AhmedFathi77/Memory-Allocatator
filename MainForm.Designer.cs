/*
 * Created by SharpDevelop.
 * User: leenovoz510
 * Date: 4/26/2018
 * Time: 9:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MemoryMetro
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.metroButton3 = new MetroFramework.Controls.MetroButton();
			this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.metroPanel1.SuspendLayout();
			this.metroPanel2.SuspendLayout();
			this.metroPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.Controls.Add(this.metroButton1);
			this.metroPanel1.Controls.Add(this.textBox2);
			this.metroPanel1.Controls.Add(this.metroLabel2);
			this.metroPanel1.Controls.Add(this.textBox1);
			this.metroPanel1.Controls.Add(this.metroLabel1);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(10, 79);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Size = new System.Drawing.Size(274, 138);
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.MetroPanel1Paint);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(13, 94);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(242, 32);
			this.metroButton1.TabIndex = 6;
			this.metroButton1.Text = "Insert Hole";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.MetroButton1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(138, 55);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(117, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// metroLabel2
			// 
			this.metroLabel2.Location = new System.Drawing.Point(13, 52);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(113, 23);
			this.metroLabel2.TabIndex = 4;
			this.metroLabel2.Text = "Starting Address :";
			this.metroLabel2.Click += new System.EventHandler(this.MetroLabel2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(138, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(117, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// metroLabel1
			// 
			this.metroLabel1.Location = new System.Drawing.Point(13, 16);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(66, 24);
			this.metroLabel1.TabIndex = 2;
			this.metroLabel1.Text = "Hole Size";
			this.metroLabel1.Click += new System.EventHandler(this.MetroLabel1Click);
			// 
			// metroLabel3
			// 
			this.metroLabel3.Location = new System.Drawing.Point(23, 60);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(100, 26);
			this.metroLabel3.TabIndex = 7;
			this.metroLabel3.Text = "Hole Process";
			this.metroLabel3.Click += new System.EventHandler(this.MetroLabel3Click);
			// 
			// metroPanel2
			// 
			this.metroPanel2.Controls.Add(this.comboBox1);
			this.metroPanel2.Controls.Add(this.metroButton3);
			this.metroPanel2.Controls.Add(this.metroLabel8);
			this.metroPanel2.Controls.Add(this.comboBox2);
			this.metroPanel2.Controls.Add(this.metroButton2);
			this.metroPanel2.Controls.Add(this.metroLabel7);
			this.metroPanel2.Controls.Add(this.metroLabel6);
			this.metroPanel2.Controls.Add(this.textBox4);
			this.metroPanel2.Controls.Add(this.textBox3);
			this.metroPanel2.Controls.Add(this.metroLabel5);
			this.metroPanel2.HorizontalScrollbarBarColor = true;
			this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel2.HorizontalScrollbarSize = 10;
			this.metroPanel2.Location = new System.Drawing.Point(293, 79);
			this.metroPanel2.Name = "metroPanel2";
			this.metroPanel2.Size = new System.Drawing.Size(458, 138);
			this.metroPanel2.TabIndex = 8;
			this.metroPanel2.VerticalScrollbarBarColor = true;
			this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel2.VerticalScrollbarSize = 10;
			this.metroPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.MetroPanel2Paint);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"First Fit",
									"Best Fit"});
			this.comboBox1.Location = new System.Drawing.Point(115, 70);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(101, 21);
			this.comboBox1.TabIndex = 12;
			// 
			// metroButton3
			// 
			this.metroButton3.Location = new System.Drawing.Point(222, 68);
			this.metroButton3.Name = "metroButton3";
			this.metroButton3.Size = new System.Drawing.Size(227, 58);
			this.metroButton3.TabIndex = 11;
			this.metroButton3.Text = "Deallocate Process";
			this.metroButton3.UseSelectable = true;
			this.metroButton3.Click += new System.EventHandler(this.MetroButton3Click);
			// 
			// metroLabel8
			// 
			this.metroLabel8.Location = new System.Drawing.Point(222, 16);
			this.metroLabel8.Name = "metroLabel8";
			this.metroLabel8.TabIndex = 10;
			this.metroLabel8.Text = "Process Name";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(324, 16);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 9;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(15, 103);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(200, 23);
			this.metroButton2.TabIndex = 8;
			this.metroButton2.Text = "Allocate Process";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.MetroButton2Click);
			// 
			// metroLabel7
			// 
			this.metroLabel7.Location = new System.Drawing.Point(15, 68);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.TabIndex = 7;
			this.metroLabel7.Text = "Method";
			// 
			// metroLabel6
			// 
			this.metroLabel6.Location = new System.Drawing.Point(15, 39);
			this.metroLabel6.Name = "metroLabel6";
			this.metroLabel6.Size = new System.Drawing.Size(87, 23);
			this.metroLabel6.TabIndex = 6;
			this.metroLabel6.Text = "Size";
			this.metroLabel6.Click += new System.EventHandler(this.MetroLabel6Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(115, 42);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(115, 16);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 3;
			// 
			// metroLabel5
			// 
			this.metroLabel5.Location = new System.Drawing.Point(15, 13);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(94, 23);
			this.metroLabel5.TabIndex = 2;
			this.metroLabel5.Text = "Process Name";
			// 
			// metroLabel4
			// 
			this.metroLabel4.Location = new System.Drawing.Point(306, 66);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(100, 26);
			this.metroLabel4.TabIndex = 2;
			this.metroLabel4.Text = "Process Data";
			// 
			// metroPanel3
			// 
			this.metroPanel3.Controls.Add(this.panel1);
			this.metroPanel3.Controls.Add(this.listBox1);
			this.metroPanel3.HorizontalScrollbarBarColor = true;
			this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel3.HorizontalScrollbarSize = 10;
			this.metroPanel3.Location = new System.Drawing.Point(10, 223);
			this.metroPanel3.Name = "metroPanel3";
			this.metroPanel3.Size = new System.Drawing.Size(741, 341);
			this.metroPanel3.TabIndex = 9;
			this.metroPanel3.VerticalScrollbarBarColor = true;
			this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel3.VerticalScrollbarSize = 10;
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(427, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(301, 320);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.AutoScroll = true;
			this.panel2.Location = new System.Drawing.Point(12, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(261, 314);
			this.panel2.TabIndex = 4;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(13, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(408, 186);
			this.listBox1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 578);
			this.Controls.Add(this.metroPanel3);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroPanel2);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.metroPanel1);
			this.Name = "MainForm";
			this.Text = "Memory Allocator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.metroPanel1.ResumeLayout(false);
			this.metroPanel1.PerformLayout();
			this.metroPanel2.ResumeLayout(false);
			this.metroPanel2.PerformLayout();
			this.metroPanel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox listBox1;
		private MetroFramework.Controls.MetroPanel metroPanel3;
		private System.Windows.Forms.ComboBox comboBox1;
		private MetroFramework.Controls.MetroButton metroButton3;
		private System.Windows.Forms.ComboBox comboBox2;
		private MetroFramework.Controls.MetroLabel metroLabel8;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private MetroFramework.Controls.MetroLabel metroLabel6;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroPanel metroPanel2;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton metroButton1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroPanel metroPanel1;
	}
}
