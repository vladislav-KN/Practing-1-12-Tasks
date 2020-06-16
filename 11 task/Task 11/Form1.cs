using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_11
{
    public partial class Form1 : Form
    {
        char[] rusAS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        char[] rusAB = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        char[] engAS = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] engAB = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int n = (int)numericUpDown1.Value;
            if (s != "")
            {
                int nRu, nEn;
                int temp = n;
                while (temp > 33)
                {
                    temp -= 33;
                }
                nRu = temp;
                temp = n;
                while (temp > 26)
                {
                    temp -= 26;
                }
                nEn = temp;
                string ret = "";
                for (int i = 0; i < s.Length; i++)
                {
                    bool ok = false;
                    for (int j = 0; j < 33; j++)
                    {
                        if (rusAS[j] == s[i])
                        {
                            int ind = j + nRu;
                            ok = true;
                            if (ind > 32)
                            {
                                ind -= 33;
                            }
                            ret += rusAS[ind];
                            break;
                        }
                        else if (rusAB[j] == s[i])
                        {
                            int ind = j + nRu;
                            ok = true;
                            if (ind > 32)
                            {
                                ind -= 33;
                            }
                            ret += rusAB[ind];
                            break;
                        }
                    }
                    for (int j = 0; j < 26; j++)
                    {
                        if (engAS[j] == s[i])
                        {
                            int ind = j + nEn;
                            ok = true;
                            if (ind > 25)
                            {
                                ind -= 26;
                            }
                            ret += engAS[ind];
                            break;
                        }
                        else if (engAB[j] == s[i])
                        {
                            int ind = j+nEn;
                            ok = true;
                            if (ind>25)
                            {
                                ind -= 26;
                            }
                            ret += engAB[ind];
                            break;
                        }
                    }
                    if (!ok)
                    {
                        ret += s[i];
                    }
                }
                textBox1.Text = ret;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            int n = (int)numericUpDown2.Value;
            if (s != "")
            {
                int nRu, nEn;
                int temp = n;
                while (temp > 33)
                {
                    temp -= 33;
                }
                nRu = temp;
                temp = n;
                while (temp > 26)
                {
                    temp -= 26;
                }
                nEn = temp;
                string ret = "";
                for (int i = 0; i < s.Length; i++)
                {
                    bool ok = false;
                    for (int j = 0; j < 33; j++)
                    {
                        if (rusAS[j] == s[i])
                        {
                            int ind = j - nRu;
                            ok = true;
                            if (ind < 0)
                            {
                                ind += 33;
                            }
                            ret += rusAS[ind];
                            break;
                        }
                        else if (rusAB[j] == s[i])
                        {
                            int ind = j - nRu;
                            ok = true;
                            if (ind < 0)
                            {
                                ind += 33;
                            }
                            ret += rusAB[ind];
                            break;
                        }
                    }
                    for (int j = 0; j < 26; j++)
                    {
                        if (engAS[j] == s[i])
                        {
                            int ind = j - nEn;
                            ok = true;
                            if (ind < 0)
                            {
                                ind += 26;
                            }
                            ret += engAS[ind];
                            break;
                        }
                        else if (engAB[j] == s[i])
                        {
                            int ind = j - nEn;
                            ok = true;
                            if (ind < 0)
                            {
                                ind += 26;
                            }
                            ret += engAB[ind];
                            break;
                        }
                    }
                    if (!ok)
                    {
                        ret += s[i];
                    }
                }
                textBox2.Text = ret;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
