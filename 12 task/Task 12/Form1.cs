using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12
{
    public partial class Form1 : Form
    {
        public class Tree
        {
            public Tree left;
            public Tree right;
            public int data { get; private set; }
            public Tree()
            {
                data = default;
                left = null;
                right = null;
            }

            public Tree(int d)
            {
                data = d;
                left = null;
                right = null;

            }
            public void insert(Tree aTree, ref int comparisons, ref int shipment)
            {
                if (aTree.data < data)
                {
                    comparisons++;
                    if (left != null) left.insert(aTree, ref comparisons, ref shipment);
                    else
                    {
                        left = aTree;
                        shipment++;
                    }
                }
                else
                {
                    comparisons++;
                    if (right != null) right.insert(aTree, ref comparisons, ref shipment);
                    else
                    {
                        right = aTree;
                        shipment++;
                    }
                }
            }
            public void Run(Tree visitor, Form1 form)
            {
                if (visitor != null)
                {
                    Run(visitor.left, form);
                    form.textBox3.Text += visitor;
                    Run(visitor.right, form);
                }
            }
            public override string ToString()
            {
                return data + " ";
            }

        }
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Упорядоченный по возрастанию";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        static int[] SortSH(int[] mass, out int comparisons, out int shipment)
        {
            int size = mass.Length;
            comparisons = 0;
            shipment = 0;
            for (int step = size / 2; step > 0; step /= 2)
                for (int i = step; i < size; i++)
                {

                    int j = i - step;
                    while (true)
                    {
                        if (j >= 0 && mass[j] > mass[j + step])
                        {

                            int tmp = mass[j];
                            mass[j] = mass[j + step];
                            mass[j + step] = tmp;
                            shipment++;
                            comparisons++;
                            j -= step;
                        }
                        else
                        {
                            comparisons++;
                            break;
                        }
                    }

                }
            return mass;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            Random rnd = new Random();
            int n = (int) numericUpDown1.Value;
            int[] mass1 = new int[n];
            int[] mass1Copy = new int[n];
            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(-1000, 1001);
                mass1[i] = j;
                mass1Copy[i] = j;
            }
            switch (comboBox1.SelectedItem)
            {
                case "Упорядоченный по возрастанию":
                    Array.Sort(mass1);
                    break;
                case "Упорядоченный по убыванию":
                    int last = mass1.Length;

                    for (bool sorted = last == 0; !sorted; --last)
                    {
                        sorted = true;
                        for (int i = 1; i < last; ++i)
                        {
                            if (mass1[i - 1] < mass1[i])
                            {
                                sorted = false;

                                int tmp = mass1[i - 1];
                                mass1[i - 1] = mass1[i];
                                mass1[i] = tmp;
                            }
                        }
                    }
                    break;
            }
            foreach (int wright in mass1)
            {
                textBox1.Text += wright + " ";
            }
            Tree res = new Tree(mass1Copy[0]);
            DateTime dateStart = new DateTime();
            DateTime dateEnd = new DateTime();
            int comparisons; int shipment;
            dateStart = DateTime.Now;
            SortSH(mass1, out comparisons, out shipment);
            dateEnd = DateTime.Now;
            foreach (int wright in mass1)
            {
                textBox2.Text += wright + " ";
            }
            label3.Text = $"Для {n} сортировка Шелла длилась {dateEnd - dateStart} времени с количеством сравнений {comparisons} и числом перестановок {shipment}";
            comparisons = 0;
            shipment = 0;
            dateStart = DateTime.Now;
            for (int i = 1; i < n; i++)
                res.insert(new Tree(mass1Copy[i]), ref comparisons, ref shipment);
            dateEnd = DateTime.Now;
            res.Run(res,this);
            label4.Text = $"Для {n} сортировка Деревом поиска {dateEnd - dateStart} времени с количеством сравнений {comparisons} и числом перестановок {shipment}";
        }
    }
}
