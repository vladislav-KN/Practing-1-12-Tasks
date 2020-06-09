using System;

namespace _6_task
{
    class Program
    {
        static void Numbers(int a1,int a2,int a3, int M,int N,int L,int Ms,int Ns)
        {
            int ak = (7 / 3 * a3 + a2) / 2 * a1;
            if (N == 0)
            {
                Console.WriteLine($"Выведены все {Ns} элементы");
                return;
            }
            else if(M==0)
            {
                Console.WriteLine($"Выведены все первые {Ms} элементы");
                return;
            }
            else if (ak > L)
            {
                Console.WriteLine($"Число {ak} больше числа L, который равен {L}");
                return;
            }
            Numbers(a2, a3, ak, M - 1, N - 1, L, Ms, Ns);
            Console.WriteLine(ak);
        }
        static int numEnter(string message)
        {
            int enter;
            while (true)
            {
                Console.Write(message);
                bool ok = int.TryParse(Console.ReadLine(),out enter);
                if (ok)
                {
                    break;
                }
            }
            return enter;
        }
        static void Main(string[] args)
        {
            int a1, a2, a3, m, n, l;
            a1 = numEnter("Введите a1: ");
            a2 = numEnter("Введите a2: ");
            a3 = numEnter("Введите a3: ");
            m = numEnter("Введите M: ");
            n = numEnter("Введите N: ");
            l = numEnter("Введите L: ");
            Numbers(a1, a2, a3, m, n, l, m, n);
            Console.WriteLine(a3);
            Console.WriteLine(a2);
            Console.WriteLine(a1);

        }
    }
}
