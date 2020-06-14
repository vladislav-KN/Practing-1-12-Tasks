using System;
using System.Diagnostics.CodeAnalysis;

namespace _11_task
{
    public class Program
    {
        static char[] rusAS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        static char[] rusAB = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        static char[] engAS = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static char[] engAB = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static string shifr(int n, string s)
        {
            int nRu, nEn;
            int temp = n;
            while (temp > 33)
            {
                temp -= 33;
            }
            nRu = temp;
            temp = n;
            while (temp > 26)
            {
                temp -= 26;
            }
            nEn = temp;
            string ret = "";
            for (int i = 0; i < s.Length; i++)
            {
                bool ok = false;
                for (int j = 0; j < 33; j++)
                {
                    if (rusAS[j] == s[i])
                    {
                        int ind = j + nRu;
                        ok = true;
                        if (ind > 32)
                        {
                            ind -= 33;
                        }
                        ret += rusAS[ind];
                        break;
                    }
                    else if (rusAB[j] == s[i])
                    {
                        int ind = j + nRu;
                        ok = true;
                        if (ind > 32)
                        {
                            ind -= 33;
                        }
                        ret += rusAB[ind];
                        break;
                    }
                }
                for (int j = 0; j < 26; j++)
                {
                    if (engAS[j] == s[i])
                    {
                        int ind = j + nEn;
                        ok = true;
                        if (ind > 25)
                        {
                            ind -= 26;
                        }
                        ret += engAS[ind];
                        break;
                    }
                    else if (engAB[j] == s[i])
                    {
                        int ind = j + nEn;
                        ok = true;
                        if (ind > 25)
                        {
                            ind -= 26;
                        }
                        ret += engAB[ind];
                        break;
                    }
                }
                if (!ok)
                {
                    ret += s[i];
                }
            }
            return ret;
        }
        public static string deshifr(int n, string s) 
        {
            int nRu, nEn;
            int temp = n;
            while (temp > 33)
            {
                temp -= 33;
            }
            nRu = temp;
            temp = n;
            while (temp > 26)
            {
                temp -= 26;
            }
            nEn = temp;
            string ret = "";
            for (int i = 0; i < s.Length; i++)
            {
                bool ok = false;
                for (int j = 0; j < 33; j++)
                {
                    if (rusAS[j] == s[i])
                    {
                        int ind = j - nRu;
                        ok = true;
                        if (ind < 0)
                        {
                            ind += 33;
                        }
                        ret += rusAS[ind];
                        break;
                    }
                    else if (rusAB[j] == s[i])
                    {
                        int ind = j - nRu;
                        ok = true;
                        if (ind < 0)
                        {
                            ind += 33;
                        }
                        ret += rusAB[ind];
                        break;
                    }
                }
                for (int j = 0; j < 26; j++)
                {
                    if (engAS[j] == s[i])
                    {
                        int ind = j - nEn;
                        ok = true;
                        if (ind < 0)
                        {
                            ind += 26;
                        }
                        ret += engAS[ind];
                        break;
                    }
                    else if (engAB[j] == s[i])
                    {
                        int ind = j - nEn;
                        ok = true;
                        if (ind < 0)
                        {
                            ind += 26;
                        }
                        ret += engAB[ind];
                        break;
                    }
                }
                if (!ok)
                {
                    ret += s[i];
                }
            }
            return ret;
        }
        [ExcludeFromCodeCoverage]
        static int numEnter(string str)
        {
            int k;
            bool ok;
            do
            {
                Console.Write(str);
                ok = int.TryParse(Console.ReadLine(), out k);
                if (k < 0)
                {
                    ok = false;
                }
            } while (!ok);
            return k;
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            //1072 - а, 1103 - я
            //1040 - А, 1071 - Я
            //97 - a, 122 - z
            //65 - A, 90 - Z
            do
            {
                Console.Write("Введите строку для шифрования: ");
                string s = Console.ReadLine();
                int n = numEnter("Введите число сдвига: ");

                Console.WriteLine(shifr(n,s));
                Console.Write("Введите строку для дешифрования: ");
                s = Console.ReadLine();
                n = numEnter("Введите число сдвига: ");

                Console.WriteLine(deshifr(n, s));
            } while (true);
        }
    }
}
