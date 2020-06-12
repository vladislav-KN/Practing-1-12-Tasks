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

            public void insert(Tree aTree, ref ulong comparisons)
            {

                    if (Greater2( aTree.data, this.data, ref comparisons))

                    {
                        if (left != null) left.insert(aTree, ref comparisons);
                        else
                        {
                            left = aTree;
                        }
                    }
                    else
                    {
                        if (right != null) right.insert(aTree, ref comparisons);
                        else
                        {
                            right = aTree;
                        }
                    }
                }
            static bool Greater2(int a, int b, ref ulong cn)
            {
                cn++;
                if (a < b)
                {
                    return true;
                }
                return false;
            }
            public void Run(Tree visitor, TextBox form)
            {
                if (visitor != null)
                {
                    Run(visitor.left, form);
                    form.Text += visitor;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static bool Greater(int a, int b, ref ulong cn)
        {
            cn++;
            if (a > b)
            {
                return true;
            }
            return false;
        }
        

        static int[] SortSH(int[] mass, out ulong comparisons, out ulong shipment)
        {
            int size = mass.Length;
            comparisons = 0;
            shipment = 0;
            for (int step = size / 2; step > 0; step /= 2)
                for (int i = step; i < size; i++)
                {
                    for (int j = i - step; j >= 0 && Greater(mass[j] , mass[j + step], ref comparisons); j -= step, shipment++)
                    {

                        int tmp = mass[j];
                        mass[j] = mass[j + step];
                        mass[j + step] = tmp;
                       
                    }

                }
            return mass;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            Random rnd = new Random();
            int n = (int)numericUpDown1.Value;
            int[] mass1 = new int[n];
            int[] mass1Copy = new int[n];
            int[] mass2 = new int[n];
            int[] mass2Copy = new int[n];
            int[] mass3 = new int[n];
            int[] mass3Copy = new int[n];
            for (int i = 0; i < n; i++)
            {
                int j = rnd.Next(-n, n+1);
                mass1[i] = j;
                mass1Copy[i] = j;
                mass2[i] = j;
                mass2Copy[i] = j;
                mass3[i] = j;
                mass3Copy[i] = j;
            }
            Array.Sort(mass2);
            Array.Sort(mass3);
            Array.Reverse(mass3);
            Array.Sort(mass2Copy);
            Array.Sort(mass3Copy);
            Array.Reverse(mass3Copy);
            if (!checkBox1.Checked)
            {
                foreach (int wright in mass1)
                {
                    textBox1.Text += wright + " ";
                }
                foreach (int wright in mass2)
                {
                    textBox6.Text += wright + " ";
                }
                foreach (int wright in mass3)
                {
                    textBox9.Text += wright + " ";
                }
            }
            #region не сортированный 
            Tree res = new Tree(mass1Copy[0]);
            DateTime dateStart = new DateTime();
            DateTime dateEnd = new DateTime();
            ulong comparisons; ulong shipment;
            dateStart = DateTime.Now;
            SortSH(mass1, out comparisons, out shipment);
            dateEnd = DateTime.Now;
            if (!checkBox1.Checked)
            {
                foreach (int wright in mass1)
                {
                    textBox2.Text += wright + " ";
                }
            }
            long time = dateEnd.Ticks - dateStart.Ticks;
             
            label3.Text = $"Для {n} сортировка Шелла длилась  {time} времени с количеством сравнений {comparisons} и числом перестановок {shipment}";
            comparisons = 0;
            shipment = 0;
            dateStart = DateTime.Now;

                for (int i = 1; i < n; i++)
                    res.insert(new Tree(mass1Copy[i]), ref comparisons);

            dateEnd = DateTime.Now;
            if (!checkBox1.Checked)
            {
                res.Run(res, textBox3);
            }
            time =dateEnd.Ticks - dateStart.Ticks;
            label4.Text = $"Для {n} сортировка Деревом поиска {time} времени с количеством сравнений {comparisons}";
            #endregion
            #region сортированный по возрастанию
            Tree res2 = new Tree(mass2Copy[0]);
            dateStart = new DateTime();
            dateEnd = new DateTime();
            dateStart = DateTime.Now;
            SortSH(mass2, out comparisons, out shipment);
            dateEnd = DateTime.Now;
            if (!checkBox1.Checked)
            {
                foreach (int wright in mass2)
                {
                    textBox5.Text += wright + " ";
                }
            }
            time =dateEnd.Ticks - dateStart.Ticks;

            label6.Text = $"Для {n} сортировка Шелла длилась {time} времени с количеством сравнений {comparisons} и числом перестановок {shipment}";
            comparisons = 0;
            shipment = 0;
            dateStart = DateTime.Now;
            for (int i = 1; i < n; i++)
                if (i > 9538)
                {
                    res2.insert(new Tree(mass2Copy[i]), ref comparisons);
                }
                else
                {
                    res2.insert(new Tree(mass2Copy[i]), ref comparisons);
                }
                    dateEnd = DateTime.Now;
             if (!checkBox1.Checked)
            {
                res2.Run(res2, textBox4);
            }
            time =dateEnd.Ticks - dateStart.Ticks;
            label5.Text = $"Для {n} сортировка Деревом поиска {time} времени с количеством сравнений {comparisons}";
            #endregion
            #region сортированный по возрастанию
            Tree res3 = new Tree(mass3Copy[0]);
            dateStart = new DateTime();
            dateEnd = new DateTime();
            dateStart = DateTime.Now;
            SortSH(mass3, out comparisons, out shipment);
            dateEnd = DateTime.Now;
            if (!checkBox1.Checked)
            {
                foreach (int wright in mass2)
                {
                    textBox8.Text += wright + " ";
                }
            }
            time =dateEnd.Ticks - dateStart.Ticks;
            label9.Text = $"Для {n} сортировка Шелла длилась {time} времени с количеством сравнений {comparisons} и числом перестановок {shipment}";
            comparisons = 0;
            shipment = 0;
            dateStart = DateTime.Now;

            for (int i = 1; i < n; i++)
                res3.insert(new Tree(mass3Copy[i]), ref comparisons);
            dateEnd = DateTime.Now;
            if (!checkBox1.Checked)
            {
            res3.Run(res3, textBox7);
            }
            time =dateEnd.Ticks - dateStart.Ticks;
            label8.Text = $"Для {n} сортировка Деревом поиска {time} времени с количеством сравнений {comparisons}";
            #endregion
        }
    }
}
