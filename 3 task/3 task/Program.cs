using System;
using System.Diagnostics.CodeAnalysis;

namespace _3_task
{
    public class Program
    {
        
        public static bool Compleat(double x, double y)
        {
            double res1 = Math.Pow(x, 2) + Math.Pow(y - 1, 2);
            double res2 = 1 - Math.Pow(x, 2);
            bool ok = res1 <= 1 && res2 >= y;
            if (ok)
            {
                Console.WriteLine($"Заданные x и y падают в область. U = {x - y}.", "Ответ");
               
            }
            else
            {
                Console.WriteLine($"Заданные x и y не падают в область. U = {x * y + 7}.", "Ответ");
            }
            return ok;
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            while (true)
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
                Compleat(x, y);
            }
                
        }
    }
}
