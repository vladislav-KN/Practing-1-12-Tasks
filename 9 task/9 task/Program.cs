using System;
using System.Diagnostics.CodeAnalysis;

namespace _9_task
{
    public class Program
    {
        public static void FillUp(int n, out CircularLinkedList<int> List)
        {
            
            
            List = new CircularLinkedList<int>();
            for (int i = 1; i <= n; i++)
            {
                List.Add(i);
            }
 
        }
        [ExcludeFromCodeCoverage]
        static int numEnter(string str)
        {
            bool ok;
            int k;
            do
            {
                Console.Write(str);
                ok = int.TryParse(Console.ReadLine(), out k);
                if (k < 2)
                {
                    ok = false;
                }
            } while (!ok);
            return k;
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            while (true)
            {
                int some;
                int n = numEnter("Введите N: ");
                CircularLinkedList<int> List = new CircularLinkedList<int>();
                FillUp(n,out List);
                Random rnd = new Random();
                foreach (int i in List)
                {
                    Console.WriteLine(i);
                }
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Удаление {some}");
                List.Remove(some);
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Удаление {some}");
                List.Remove(some);
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Удаление {some}");
                List.Remove(some);
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Удаление {some}");
                List.Remove(some);
                foreach (int i in List)
                {
                    Console.WriteLine(i);
                }
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Contains(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Contains(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Contains(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Contains(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Contains(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Contains(some));
            }

        }
    }
}
