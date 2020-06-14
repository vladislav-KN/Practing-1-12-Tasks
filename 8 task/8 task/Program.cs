using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _8_task
{
    public class Program
    {
        public static void Run(int size)
        {
            Dictionary<int, int[]> firstGRPH;
            Dictionary<int, int[]> secondGRPH;
            int n = GeneraitGraph(out firstGRPH, out secondGRPH, size);
            int[,] GraphA = new int[n, n];
            int[,] GraphB = new int[n, n];
            //генерируем массив из списка
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 1; k <= size; k++)
                    {
                        if (firstGRPH[k][0] - 1 == i && firstGRPH[k][1] - 1 == j)
                        {
                            GraphA[i, j] = 1;
                            GraphA[j, i] = 1;
                            break;
                        }

                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 1; k <= size; k++)
                    {
                        if (secondGRPH[k][0] - 1 == i && secondGRPH[k][1] - 1 == j)
                        {
                            GraphB[i, j] = 1;
                            GraphB[j, i] = 1;
                        }

                    }
                }
            }
            int[,] graph = new int[n, n];

            // Массив для варианта соответствия вершин 
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = i;

            bool ok = false;
            // Генерируем перестановку и проверяем, совпадают ли матрицы смежности
            while (!ok)
            {
                ok = true;
                bool result = Swap(ref a);   // Генерация новой перестановки вершин
                                             // Составляем матрицу смежности по новой последовательности вершин и сравниваем с матрицей графа A
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        graph[i, j] = GraphB[a[i], a[j]];
                        if (graph[i, j] != GraphA[i, j])
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (!ok) break;
                }
            }
            // Результат
            Console.WriteLine("Биективное соответствие A = B:");
            for (int i = 0; i < n; i++)
                Console.WriteLine("{0} = {1} ", i + 1, a[i] + 1);
        }
        static int GeneraitGraph(out Dictionary<int, int[]> firstGraph, out Dictionary<int, int[]> secondGraph, int lenOfGrph)
        {
            
            firstGraph = new Dictionary<int, int[]>();//первый граф
            secondGraph = new Dictionary<int, int[]>();//второй граф
            Random rnd = new Random();
            double s = Math.Ceiling(1 + (Math.Pow((1 + 8 * lenOfGrph), 0.5)));//если все вершины соединены
            double min = Math.Ceiling(s / 2);//+0.0000001 для округления в большую сторону
            s = Math.Ceiling(3 + Math.Pow((8 * lenOfGrph - 7), 0.5));
            double max = Math.Ceiling(s / 2);
            int n = rnd.Next((int)min, (int)max + 1);//генерация случайного количества возможных ребер для связного графа
            Console.WriteLine("Первый граф");
            //создаем первый граф
            for (int i = 1; i <= lenOfGrph; i++)
            {
                int m, k;
                if (firstGraph.Count == 0)
                {
                    k = rnd.Next(1, n + 1);

                    while (true)
                    {
                        m = rnd.Next(1, n + 1);
                        if (m != k) break;
                    }
                }
                else
                {
                    while (true)
                    {
                        k = rnd.Next(1, n + 1);

                        while (true)
                        {
                            m = rnd.Next(1, n + 1);
                            if (m != k) break;
                        }
                        bool ok = true;
                        foreach (int kay in firstGraph.Keys)
                        {
                            if ((firstGraph[kay][0] == k && firstGraph[kay][1] == m) || (firstGraph[kay][1] == k && firstGraph[kay][0] == m))
                            {
                                ok = false;
                                break;
                            }
                        }
                        if (ok) break;
                    }
                }
                int[] mas = new int[2] { m, k };
                firstGraph.Add(i, mas);
               
            }
            firstGraph = firstGraph.OrderBy(pair => pair.Value[0]).ToDictionary(pair => pair.Key, pair => pair.Value);
            Dictionary<int, int[]> sorted = new Dictionary<int, int[]>();
            int num = 1;
            foreach(int key in firstGraph.Keys)
            {
                sorted.Add(num, firstGraph[key]);
               
                Console.WriteLine($"{num} - [{sorted[num][0]}][{sorted[num][1]}]");
                num++;
            }
            firstGraph = sorted;
            Dictionary<int, int[]> saveFG = new Dictionary<int, int[]>();
            //сохраняем для удаления строк
            foreach(int key in firstGraph.Keys)
            {
                saveFG.Add(key, firstGraph[key]);
            }
            Dictionary<int, int> random = new Dictionary<int, int>();
            List<int> massOfPICKS = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                massOfPICKS.Add(i);
            }
            //Перемешиваем вершины
            for (int i = 1; i <= n; i++)
            {
                int replace;
                while (true)
                {
                    int pick = rnd.Next(1, n + 1);
                    replace = massOfPICKS.Find(x => x == pick);
                    if (replace != 0)
                    {
                        massOfPICKS.Remove(pick);
                        break;
                    }

                }
                random.Add(i, replace);
            }
            massOfPICKS = null;
            Console.WriteLine("Второй граф");
            // Создаем случайные биективное соответствие между вершинами графов
            for (int i = 1; i <= lenOfGrph; i++)
            {
                int[] mass = new int[2];
                int tmp;
                tmp = rnd.Next(0, saveFG.Count);
                mass[0] = random[saveFG.Values.ElementAt(tmp)[0]];
                mass[1] = random[saveFG.Values.ElementAt(tmp)[1]];
                saveFG.Remove(saveFG.Keys.ElementAt(tmp));
                secondGraph.Add(i, mass);
            }
            secondGraph = secondGraph.OrderBy(pair => pair.Value[0]).ToDictionary(pair => pair.Key, pair => pair.Value);
            Dictionary<int, int[]> sorted2 = new Dictionary<int, int[]>();
            num = 1;
            foreach (int key in secondGraph.Keys)
            {
                sorted2.Add(num, secondGraph[key]);
                Console.WriteLine($"{num} - [{sorted2[num][0]}][{sorted2[num][1]}]");
                num++;
            }
            secondGraph = sorted2;
            return n;
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
                if (k < 2 || k > 50)
                {
                    ok = false;
                }
            } while (!ok);
            return k;
        }
        static bool Swap(ref int[] peak)
        {
            int index = peak.Length - 1;
            while (true)
            {
                int n = index;
                index--;
                // Находим два идущих подряд числа по возрастанию, index - одно из чисел для перестановок
                if (peak[index] < peak[n])
                {
                    // Находим второе число для перестановки, число меньшее первого найденного
                    int m = peak.Length - 1;
                    while (peak[index] >= peak[m])
                        m--;
                    // Выполняем перестановку
                    int t = peak[index]; peak[index] = peak[m]; peak[m] = t;
                    // При необходимости, возвращаем числа после перестановки в исходный порядок
                    Array.Reverse(peak, n, peak.Length - n);
                    return true;
                }
                if (index == 0)
                {
                    Array.Reverse(peak);
                    return false;
                }
            }
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            while (true) 
            { 
                int size = numEnter("Введите количество ребер в графах: ");
                Run(size);
            }
        }
    }
}
