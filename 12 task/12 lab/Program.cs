using System;

namespace _12_task
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
        public void insert(Tree aTree,ref int comparisons, ref int shipment)
        {
            if (aTree.data < data)
            {
                comparisons++;
                if (left != null) left.insert(aTree,ref comparisons ,ref shipment);
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
        public void Run(Tree visitor)
        {
            if (visitor != null)
            {
                Run(visitor.left);
                Console.Write(visitor + " ");
                Run(visitor.right);
            }
        }
        public override string ToString()
        {
            return data + " ";
        }

    }
    class Program
    {
        static int[]  SortSH(int[] mass, out int comparisons, out int shipment)
        {
            int size = mass.Length;
            comparisons = 0;
            shipment = 0;
            for (int step = size / 2; step > 0; step /= 2)
                for (int i = step; i < size; i++) 
                {
                     
                    int j = i - step; 
                    while(true)
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
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                int n = int.Parse(Console.ReadLine());
                int[] mass1 = new int[n];
                for (int i = 0; i < n; i++)
                {
                    mass1[i] = rnd.Next(-10000,10001);
                }
                foreach(int wright in mass1)
                {
                    Console.Write(wright + " ");
                }
                Tree res = new Tree(mass1[0]);
                DateTime dateStart = new DateTime();
                DateTime dateEnd = new DateTime();
                dateStart = DateTime.Now;
                int comparisons; int shipment;
                int[] massR = SortSH(mass1, out comparisons, out shipment);
                dateEnd = DateTime.Now;
                foreach (int wright in massR)
                {
                    Console.Write(wright + " ");
                }
                Console.WriteLine($"Для {n} сортировка Шелла длилась {dateEnd - dateStart} с количеством сравнений {comparisons} и числом перестановок {shipment}");
                comparisons = 0;
                shipment = 0;
                dateStart = DateTime.Now;
                for (int i = 1; i < n; i++)
                    res.insert(new Tree(mass1[i]), ref comparisons, ref shipment);
                dateEnd = DateTime.Now;
                res.Run(res);
                Console.WriteLine($"Для 10 сортировка Деревом поиска {dateEnd - dateStart} с количеством сравнений {comparisons} и числом перестановок {shipment}");


               
            }
        }
    }
    
}
 