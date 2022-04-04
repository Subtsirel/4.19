using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            textBox4.Text = "Работу выполнила ст. Субцирел Д.В" + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y =Math.Pow((Math.Log(Math.Sin(Math.Pow(x,3)+0.0025))),3/2)+0.8*Math.Pow(10,-3);
                textBox4.Text += "x=" + Convert.ToString(x) +  "; y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
