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
        double mocnina(int a, int b)
        {
            double vysledek = 1;
            if (b > 0)
            {
                for (int i = 0; i < b; i++)
                {
                    vysledek *= a;
                }
            }
            else if (b < 0)
            {
                for (int i = 0; i > b; i--)
                {
                    vysledek /= a;
                }
            }
            return vysledek;
        }
        double faktorial(double a)
        {
            double vysledek = 1;
            while (a > 0)
            {
                vysledek *= a;
                a--;
            }
            return vysledek;
        }
        int CifLichSoucet(int a)
        {
            int soucet = 0;
            while (a > 0)
            {
                if ((a % 10) % 2 != 0) soucet += a % 10;
                a /= 10;
            }
            return soucet;
        }
        bool prvocislo(int a)
        {
            if (a <= 1) return false;
            if (a == 2) return true;
            for (int i = 3; i < a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBox1.Text);
            int b1 = Convert.ToInt32(textBox2.Text);
            int a2 = Convert.ToInt32(textBox3.Text);
            int b2 = Convert.ToInt32(textBox4.Text);
            label1.Text = vzdalenost(a1, b1, a2, b2).ToString();

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label6.Text = mocnina(a, b).ToString();

            double x = Convert.ToDouble(textBox1.Text);
            label7.Text = faktorial(a).ToString();

            int y = Convert.ToInt32(textBox1.Text);
            label9.Text = CifLichSoucet(a).ToString();

            int z = Convert.ToInt32(textBox1.Text);
            label8.Text = prvocislo(a).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox5.Text);
            int b = Convert.ToInt32(textBox6.Text);
            label2.Text = (a + b).ToString();
            label3.Text = (a - b).ToString();
            label4.Text = (a * b).ToString();
            label5.Text = (Convert.ToDouble(a) / Convert.ToDouble(b)).ToString();
        }
    }
}
