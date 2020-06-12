using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onlyINT(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            char chr;
            char notMin = ' ';
            try
            {
                chr = textBox1.Text[textBox1.SelectionStart-1];

            }
            catch
            {
                chr = ' ';
            }
            try
            {
                notMin = textBox1.Text[textBox1.SelectionStart];

            }
            catch
            {
                notMin = ' ';
            }
            if ((chr !=' ' || notMin == '-') && number =='-' )
                e.Handled = true;
            else if(!Char.IsDigit(chr) && number == ' ')
                e.Handled = true;
            else if (!Char.IsDigit(number) && number != '-' && number != ' ' && number != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            label2.Text = "";
            string[] strs;
            int[] treeElements;
            bool ok = false;
            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == ' ')
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
                do
                {
                    strs = textBox1.Text.Split(' ');
                    treeElements = new int[strs.Length];
                    int i = 0;
                    for (; i < strs.Length; i++)
                    {
                        ok = int.TryParse(strs[i], out treeElements[i]);
                        if (!ok)
                        {
                            break;
                        }
                    }
                    if (!ok)
                    {
                        MessageBox.Show($"Ошибка ввода числа {strs[i]}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                } while (!ok);
                if (ok)
                {
                    Tree tree = new Tree(treeElements);
                    int level;
                    List<Point> list;
                    tree.Run(out level, out list);
                    label2.Text = "Количество уровней: " + level;
                    for (int i = 1; i <= level; i++)
                    {
                        int num = (from c in list select c).Where(c => c.Level == i).Count();
                        textBox2.Text += $"Количество элементов на {i}-м ярусе: " + num + Environment.NewLine;
                    }
                }
            }
        }
    }
}
