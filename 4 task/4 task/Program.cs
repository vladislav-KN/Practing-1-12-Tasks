using System;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double,double> func = (x) => (Math.Pow(x, 4)+2*(Math.Pow(x, 3))-x-1);
            while (true)
            {
                double e;
                double up = 1;
                double under = 0;
                double center;
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
                double resUp;
                double resUnder = func(under); ;
                while (Math.Abs(under-up)>e)
                {
                    center = (under + up) / 2;
                    resUp = func(center);
                    if(resUp * resUnder < 0)
                    {
                        up = center;
                    }
                    else
                    {
                        under = center;
                        resUnder = resUp;
                    }
                }
                Console.WriteLine(under);
            }
        }
    }
}
