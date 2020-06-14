using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    class Func
    {
        static int Change(int x)
        {
            return x == 2 ? 0 : x + 1;
        }

        static int calculateByIndex(int n)
        {
            if (n == 1)
                return 0;
            int level = (int)(Math.Log(n, 2) + 0.99999);
            uint len = (uint)1 << level;
            return Change(calculateByIndex((int)(((uint)n) - len / 2)));
        }
        public static void Some()
        {
            int get;
            using (StreamReader sw = new StreamReader("INPUT.TXT"))
            {
                get = int.Parse(sw.ReadLine());
            }
            int ret = calculateByIndex(get);
            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                sw.WriteLine(ret);
            }
        }
    }
}
