/*
 * Created by SharpDevelop.
 * User: leenovoz510
 * Date: 4/26/2018
 * Time: 9:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace MemoryMetro
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : MetroForm
	{
	    public int x = -150;
        public int y = 0;
	   public int processcounter = 0 ;
        
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			panel2.Paint += new PaintEventHandler(Panel1Paint);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		void MetroButton1Click(object sender, EventArgs e)
		{
			int size= Convert.ToInt32( textBox1.Text);
            int address = Convert.ToInt32(textBox2.Text);
            methodology.inserthole(new hole(address,size));
            listBox1.Items.Add("You inserted a hole of size "+ size+" kb at 0x"+ address);
            methodology.memory = methodology.memory.OrderBy(a => a.getstratingadd()).ToList();
            foreach (var item in methodology.memory)
            {
                Console.WriteLine(item.GetType() + " :item at" + item.getstratingadd() + " with size:" + item.getsize());
            }
            Console.WriteLine("%%%%%%%%");
            methodology.holes_counter++;
            panel2.Invalidate();			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void MetroLabel3Click(object sender, EventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{	
            panel2.AutoScroll = true;
            x = 0;
            y = 0;
            foreach (var process in methodology.memory)
            {
                string type = process.type;
                Color color;
                string drawString = process.getname();
                int start_address = process.getstratingadd();
                string add_draw = "0x" + start_address;
                double sb = process.getsize();
                panel2.Height += (int)sb + 1;
                System.Drawing.Font drawFont = new System.Drawing.Font("Tahoma", 12);
                if(type == "h")
                {
                    color = System.Drawing.Color.Black;
                }
                else if (type == "p")
                {
                    color = System.Drawing.Color.Orange;
                }
                else
                {
                    color = System.Drawing.Color.Blue;
                }
                System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(color);
                System.Drawing.SolidBrush stringbrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
                System.Drawing.Graphics graphics = panel2.CreateGraphics();
                System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(x, y, 100, (int)sb);
                graphics.FillRectangle(drawBrush, rectangle);
                graphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
                graphics.DrawString(add_draw, drawFont, drawBrush, x + 100, y);
                graphics.DrawString(drawString, drawFont, stringbrush, x, y);
                y = y + (int)sb;
            }

		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
						
		}
		
		void MetroButton2Click(object sender, EventArgs e)
		{
			 int size = Convert.ToInt32(textBox4.Text);
            string name = textBox3.Text;
            if (name == "")
            {
                processcounter++;
                name = "process # "+processcounter;
            }
            #region   
            if (comboBox1.Text == "First Fit")
            {
                methodology.FirstFit(new process(name, size));
                comboBox2.Items.Add(name);
            }
            else if (comboBox1.Text == "Best Fit")
            {
                methodology.BestFit(new process(name, size));
                comboBox2.Items.Add(name);
            }
            #endregion

            listBox1.Items.Add("Allocated a process of size " +size);
            methodology.memory = methodology.memory.OrderBy(a => a.getstratingadd()).ToList();

            foreach (var item in methodology.memory)
            {
                Console.WriteLine(item.GetType()+" :item at"+item.getstratingadd()+" with size:"+item.getsize());

            }
            Console.WriteLine("%%%%%%%%");
            
           panel2.Invalidate();			
		}
		
		void MetroButton3Click(object sender, EventArgs e)
		{
			methodology.deallocate(comboBox2.Text);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            listBox1.Items.Add("removed Process "+comboBox2.Text);
            methodology.memory = methodology.memory.OrderBy(a => a.getstratingadd()).ToList();
            foreach (var item in methodology.memory)
            {
                Console.WriteLine(item.GetType() + " :item at" + item.getstratingadd() + " with size:" + item.getsize());

            }
            Console.WriteLine("%%%%%%%%");
            panel2.Invalidate();			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void MetroLabel2Click(object sender, EventArgs e)
		{
			
		}
		
		void MetroLabel1Click(object sender, EventArgs e)
		{
			
		}
		
		void MetroLabel6Click(object sender, EventArgs e)
		{
			
		}
		
		void MetroPanel2Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void MetroPanel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
