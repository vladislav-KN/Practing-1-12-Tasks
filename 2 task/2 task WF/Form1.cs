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

namespace _2_task_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (int.Parse(textBox1.Text) >= 0 && int.Parse(textBox2.Text) >= 2)
                {
                    using (StreamWriter sw = new StreamWriter("INPUT.TXT"))
                    {
                        sw.WriteLine(textBox1.Text + " " + textBox2.Text);
                    }
                    Task2.Compl();
                    int get;
                    using (StreamReader sw = new StreamReader("OUTPUT.TXT"))
                    {
                        get = int.Parse(sw.ReadLine());
                    }
                    MessageBox.Show($"2^(2^{textBox1.Text}) по модулю {textBox2.Text} = {get}", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (int.Parse(textBox2.Text) >= 2)
                {
                    MessageBox.Show("Введите число большее 0", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Select();
                }
                else if (int.Parse(textBox1.Text) >= 0)
                {
                    MessageBox.Show("Введите число большее 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Select();
                }
                else
                {
                    MessageBox.Show("Введите число большее 0 в первое поле ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Введите число большее 2 во второе поле ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else if(textBox1.Text == "")
            {
                MessageBox.Show("Введите число в первое поле ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBox2.Text == "")
            {
                MessageBox.Show("Введите число во второе поле ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                MessageBox.Show("Введите числа в поля ввода", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onlyINT(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }
    }
}
