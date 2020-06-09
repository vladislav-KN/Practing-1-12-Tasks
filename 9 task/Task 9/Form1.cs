using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        CircularLinkedList<int> List = new CircularLinkedList<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void DeleteClickBTN(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            Random rnd = new Random();
            List.Remove(rnd.Next(0, (int)numericUpDown1.Value)+1);
            foreach (int i in List)
            {
                textBox1.Text += i + " ";
            }
        }

        private void AddClickBTN(object sender, EventArgs e)
        {
            textBox1.Text = " "; 
            int some;
            int n = (int)numericUpDown1.Value;
             
            List = new CircularLinkedList<int>();
            for (int i = 1; i <= n; i++)
            {
                List.Add(i);
            }
            foreach (int i in List)
            {
                textBox1.Text += i + " ";
            }
        }
        private void SearchClickBTN(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int search = rnd.Next(1, (int)numericUpDown1.Value+1);
            bool find = List.Find(search);
            if (find)
            {
                MessageBox.Show($"{search} найден на {List.GetId(search)+1} месте","Поиск",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{search} не найден", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
