using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double vzdalenost(int a1, int b1, int a2, int b2)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(a1 - a2), 2) + Math.Pow(Math.Abs(b1 - b2), 2));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int b1 = Convert.ToInt32(textBox2.Text);
            int a2 = Convert.ToInt32(textBox3.Text);
            int b2 = Convert.ToInt32(textBox4.Text);
            label1.Text = vzdalenost(a1, b1, a2, b2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox5.Text);
            int b = Convert.ToInt32(textBox6.Text);
            label2.Text = (a + b).ToString();
            label3.Text = (a - b).ToString();
            label4.Text = (a * b).ToString();
        }
    }
}
