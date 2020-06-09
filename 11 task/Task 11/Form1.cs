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
                            int ind = j;
                            int tmp = nRu;
                            ok = true;
                            while (tmp != 0)
                            {
                                if (ind == 32)
                                {
                                    ind = 0;
                                    tmp--;
                                }
                                else
                                {
                                    ind++;
                                    tmp--;
                                }
                            }
                            ret += rusAS[ind];
                            break;
                        }
                        else if (rusAB[j] == s[i])
                        {
                            int ind = j;
                            int tmp = nRu;
                            ok = true;
                            while (tmp != 0)
                            {
                                if (ind == 32)
                                {
                                    ind = 0;
                                    tmp--;
                                }
                                else
                                {
                                    ind++;
                                    tmp--;
                                }
                            }
                            ret += rusAB[ind];
                            break;
                        }
                    }
                    for (int j = 0; j < 26; j++)
                    {
                        if (engAS[j] == s[i])
                        {
                            int ind = j;
                            int tmp = nRu;
                            ok = true;
                            while (tmp != 0)
                            {
                                if (ind == 25)
                                {
                                    ind = 0;
                                    tmp--;
                                }
                                else
                                {
                                    ind++;
                                    tmp--;
                                }
                            }
                            ret += engAS[ind];
                            break;
                        }
                        else if (engAB[j] == s[i])
                        {
                            int ind = j;
                            int tmp = nRu;
                            ok = true;
                            while (tmp != 0)
                            {
                                if (ind == 25)
                                {
                                    ind = 0;
                                    tmp--;
                                }
                                else
                                {
                                    ind++;
                                    tmp--;
                                }
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
    }
}
