using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        static bool NextSet(ref int[] a, int n, uint m)
        {
            int j = (int)(m - 1);
            while (j >= 0 && a[j] == n)
            {
                j--;
            }
            if (j < 0)
            {
                return false;
            }
            if (a[j] >= n)
            {
                j--;
            }
            a[j]++;
            if (j == m - 1)
            {
                return true;
            }
            for (int k = j + 1; k < m; k++)
            {
                a[k] = 1;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            List<string> mass = new List<string>(textBox1.Text.Split(' '));
            mass = mass.GroupBy(x => x).Select(x => x.First()).ToList();
            uint k;
            if (mass.Count > 0&& mass.Count < 7)
            {
                k = (uint)numericUpDown1.Value;
                int[] a = new int[k];
                for (int i = 0; i < k; i++)
                {
                    a[i] = 1;
                }
                do
                {
                    string s = "";
                    for (int i = 0; i < a.Length; i++)
                    {
                        s += mass[a[i] - 1] + " ";
                    }
                    textBox2.Text += s + Environment.NewLine;

                } while (NextSet(ref a, mass.Count, k));
            }
            else if (mass.Count > 0)
            {
                MessageBox.Show("Количество букв в алфавите больше максимума", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
