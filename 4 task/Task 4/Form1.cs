using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<double, double> func = (x) => (Math.Pow(x, 4) + 2 * (Math.Pow(x, 3)) - x - 1);
            double E = (double)numericUpDown1.Value;
            if (!(E > 0))
            {
                E = 0;
            }
            double up = 1;
            double under = 0;
            double center;
            double resUp;
            double resUnder = func(under); ;
            while (Math.Abs(under - up) > E)
            {
                center = (under + up) / 2;
                resUp = func(center);
                if (resUp * resUnder < 0)
                {
                    up = center;
                }
                else
                {
                    under = center;
                    resUnder = resUp;
                }
            }
            MessageBox.Show($"Число {under} вычислено с точностью {E}");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
