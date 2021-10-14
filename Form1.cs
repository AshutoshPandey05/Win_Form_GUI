using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_GUI_Win_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             label1.Text = "Welcome to GUI Demo";
            label1.ForeColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Aqua;
            label1.Text = "Now you can understand Event Driven Programming in C#";
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Indigo;
            label1.Text = "Ashutosh Kumar Pandey";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.ForeColor = Color.AliceBlue;
            
        }

       
    }
}
