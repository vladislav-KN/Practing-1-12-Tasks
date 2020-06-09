using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = (double)numericUpDown1.Value;
            double y = (double)numericUpDown2.Value;
            double res1 = Math.Pow(x, 2) + Math.Pow(y - 1, 2);
            double res2 = 1 - Math.Pow(x, 2);
            double u;
            if (res1 <= 1 && res2 >= y)
            {
                MessageBox.Show($"Заданные x и y падают в область. U = {x-y}.","Ответ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Заданные x и y не падают в область. U = {x * y + 7}.", "Ответ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
