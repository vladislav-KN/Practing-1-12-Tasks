using System;
using System.Diagnostics.CodeAnalysis;

namespace _4_task
{
    public class Program
    {
        public static double result(double e)
        {
            Func<double, double> func = (x) => (Math.Pow(x, 4) + 2 * (Math.Pow(x, 3)) - x - 1);
            double up = 1;
            double under = 0;
            double center;
            double resUp;
            double resUnder = func(under); 
            while (Math.Abs(under - up) > e)
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
            return under;
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
           
            while (true)
            {
                double e;
                while (true)
                {
                    Console.Write("Введите погрешность: ");
                    bool ok = double.TryParse(Console.ReadLine(), out e);
                    if (ok)
                    {
                        if(((int)(e*Math.Pow(10,15)))!=0)
                            break;
                        else
                            Console.WriteLine("Слишком большая точность");
                    }
                }
                Console.WriteLine($"Число {result(e)} вычислено с точностью {e}");

            }
        }
    }
}
