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
            int[,] mass = new int[n, n];
            int max;
            int[] massOut = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(-100, 100);
                    textBox1.Text += mass[i, j] + "  ";
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
            int s = 0;
            for (int i = 0; i < n; i++)
                s += massOut[i] * massOut[n - i - 1];
            label3.Text = $"S = {s}";
        }
    }
}
