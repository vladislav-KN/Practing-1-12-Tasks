using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBox1.Text = "";
            textBox2.Text = "";
            int n = (int) numericUpDown1.Value;
            double[,] mass = new double[n, n];
            int max;
            double[] massOut = new double[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = ((double)rnd.Next(-1000, 1000)) + ((double)rnd.Next(-1000, 1000) )/ 1000;
                    textBox1.Text += String.Format("{0,3}", mass[i, j]);
                }
                textBox1.Text += Environment.NewLine;
            }
            for (int i = 0; i < n; i++)
            {
                max = 0;
                for (int j = 0; j < n; j++)
                    if (mass[i, j] > mass[i, max])
                        max = j;
                textBox2.Text += $"Строка {i} - Matrix[{i},{max}] = {mass[i, max]}" + Environment.NewLine;
                massOut[i] = mass[i, max];
            }
            double s = 0;
            for (int i = 0; i < n; i++)
                s += massOut[i] * massOut[n - i - 1];
            label3.Text = $"S = {s}";
        }
    }
}
