using System;

namespace _3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                double y, x;
                while (true)
                {
                    Console.Write("Введите x");
                    bool ok = double.TryParse(Console.ReadLine(), out x);
                    if (ok)
                    {
                        break;
                    }

                }
                while (true)
                {
                    Console.Write("Введите y");
                    bool ok = double.TryParse(Console.ReadLine(), out y);
                    if (ok)
                    {
                        break;
                    }
                }
                double res1 = Math.Pow(x, 2) + Math.Pow(y - 1, 2);
                double res2 = 1 - Math.Pow(x, 2);
                double u;
                if (res1 <= 1 && res2 >= y)
                {
                    u = x - y;
                }
                else
                {
                    u = x * y + 7;
                }
                Console.WriteLine(u);
            }
        }
    }
}
