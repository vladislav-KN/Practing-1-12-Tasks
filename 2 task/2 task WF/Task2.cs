using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_task_WF
{
    public class Task2
    {
        public static void Compl()
        {
            int n;
            int m;
            using (StreamReader sw = new StreamReader("INPUT.TXT"))
            {
                string[] Get = sw.ReadLine().Split(' ');
                n = int.Parse(Get[0]);
                m = int.Parse(Get[1]);
            }
            int r = 2 % m;
            for (int i = 0; i < n; i++)
            {
                r = (r * r) % m;
            }
            using (StreamWriter sw = new StreamWriter("OUTPUT.TXT"))
            {
                sw.Write(r);
            }
        }
    }
}
