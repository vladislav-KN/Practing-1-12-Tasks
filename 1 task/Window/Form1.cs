using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="") 
            {
                int set;
                bool ok = int.TryParse(textBox1.Text, out set);
                if (ok)
                {
                    if (set > 0)
                    {
                        using (StreamWriter sw = new StreamWriter("INPUT.TXT"))
                        {
                            sw.WriteLine(textBox1.Text);
                        }
                        Func.Some();
                        int get;
                        using (StreamReader sw = new StreamReader("OUTPUT.TXT"))
                        {
                            get = int.Parse(sw.ReadLine());
                        }
                        MessageBox.Show($"На {textBox1.Text} месте стоит число {get}", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Введите число большее 0", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Превышено максимальное значение для ввода числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите число в поле ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyINT(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
