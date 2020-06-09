using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_task
{
    class Program
    {
        static int[] numEnter(string str)
        {
            string[] strs;
            int[] k;
            bool ok = false;
            do
            {
                Console.Write(str);
                strs = Console.ReadLine().Split(" ");
                k = new int[strs.Length];
                for(int i = 0; i< strs.Length;i++)
                {
                    ok = int.TryParse(strs[i], out k[i]);
                    if (!ok)
                    {
                        break;
                    }
                }
            } while (!ok);
            return k;
        }
        static void Main(string[] args)
        {
            
            int[] treeElements = numEnter("Введите числа для добавления в дерево через пробел: ");
            Tree tree = new Tree (treeElements);
            tree.Run();
        }
    }


    
}
