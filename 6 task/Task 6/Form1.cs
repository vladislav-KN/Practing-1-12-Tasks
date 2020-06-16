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
        private void Numbers(int a1, int a2, int a3, int M, int N, int L, int Ms, int Ns, Form1 form)
        {
            int ak = (7 / 3 * a3 + a2) / 2 * a1;
            if (N == 0)
            {
                MessageBox.Show($"Выведены все {Ns} элементов", "Причина остановки", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else if (M == 0)
            {
                MessageBox.Show($"Выведены все первые {Ms} элементов", "Причина остановки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ak > L)
            {
                
                MessageBox.Show($"Число {ak} больше числа L, который равен {L}", "Причина остановки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Numbers(a2, a3, ak, M - 1, N - 1, L, Ms, Ns, form);
            form.textBox1.Text += ak + Environment.NewLine; 
        }
        private void enter_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a1, a2, a3, m, n, l;
            a1 = (int)A1.Value;
            a2 = (int)A2.Value;
            a3 = (int)A3.Value;
            m = (int)M.Value;
            n = (int)N.Value;
            l = (int)L.Value;
            Numbers(a1, a2, a3, m-3, n-3, l, m, n,this);
            textBox1.Text += a3 + Environment.NewLine + a2 + Environment.NewLine + a1 + Environment.NewLine;
        }
    }
}
