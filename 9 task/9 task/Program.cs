using System;

namespace _9_task
{
    class Program
    {
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
        static void Main(string[] args)
        {
            while (true)
            {
                int some;
                int n = numEnter("Введите N: ");
                Random rnd = new Random();
                CircularLinkedList<int> List = new CircularLinkedList<int>();
                for (int i = 1; i <= n; i++)
                {
                    List.Add(i);
                }
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
                Console.WriteLine(List.Find(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Find(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Find(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Find(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Find(some));
                some = rnd.Next(1, n + 1);
                Console.WriteLine($"Поиск {some}");
                Console.WriteLine(List.Find(some));
            }

        }
    }
}
