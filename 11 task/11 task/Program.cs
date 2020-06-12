using System;

namespace _11_task
{
    class Program
    {
        char[] rusAS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
        char[] rusAB = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ".ToCharArray();
        char[] engAS = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char[] engAB = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
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
        static void Main(string[] args)
        {
            //1072 - а, 1103 - я
            //1040 - А, 1071 - Я
            //97 - a, 122 - z
            //65 - A, 90 - Z
            
            Console.Write("Введите строку для шифрования: ");
            string s = Console.ReadLine();
            int n = numEnter("Введите число сдвига: ");
            int nRu, nEn;
            int temp=n;
            while (temp>33)
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
            string ret="";
            for (int i = 0;i<s.Length ; i++)
            {
                bool ok = false;
                for(int j = 0; j < 33; j++)
                {
                    if(rusAS[j] == s[i])
                    {
                        int ind = j;
                        int tmp = nRu;
                        ok = true;
                        while (tmp != 0)
                        {
                            if(ind == 32)
                            {
                                ind = 0;
                                tmp--;
                            }
                            else
                            {
                                ind++;
                                tmp--;
                            }
                        }
                        ret += rusAS[ind];
                        break;
                    }
                    else if (rusAB[j] == s[i])
                    {
                        int ind = j;
                        int tmp = nRu;
                        ok = true;
                        while (tmp != 0)
                        {
                            if (ind == 32)
                            {
                                ind = 0;
                                tmp--;
                            }
                            else
                            {
                                ind++;
                                tmp--;
                            }
                        }
                        ret += rusAB[ind];
                        break;
                    }
                }
                for (int j = 0; j < 26; j++)
                {
                    if (engAS[j] == s[i])
                    {
                        int ind = j;
                        int tmp = nRu;
                        ok = true;
                        while (tmp != 0)
                        {
                            if (ind == 25)
                            {
                                ind = 0;
                                tmp--;
                            }
                            else
                            {
                                ind++;
                                tmp--;
                            }
                        }
                        ret += engAS[ind];
                        break;
                    }
                    else if (engAB[j] == s[i])
                    {
                        int ind = j;
                        int tmp = nRu;
                        ok = true;
                        while (tmp != 0)
                        {
                            if (ind == 25)
                            {
                                ind = 0;
                                tmp--;
                            }
                            else
                            {
                                ind++;
                                tmp--;
                            }
                        }
                        ret += engAB[ind];
                        break;
                    }
                }
                if(!ok)
                {
                    ret += s[i];
                }
            }
            Console.WriteLine(ret);
        }
    }
}
