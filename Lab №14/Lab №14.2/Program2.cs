using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab__14._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            File.WriteAllText("L1.txt", "");
            File.WriteAllText("L2.txt", "");
            File.WriteAllText("Result.txt", "");
            string input;
            do
            {
                Console.Write("Введіть елементи списку до файлів\nДля продовження введіть exit: ");
                input = Console.ReadLine();
            } while (input != "exit");
            List<int> L1 = new List<int>();
            List<int> L2 = new List<int>();
            string[] temp = Regex.Split(File.ReadAllText("L1.txt"), @" ");
            foreach (var item in temp)
            {
                L1.Add(Convert.ToInt32(item));
            }
            L1.Sort((a, b) => b.CompareTo(a));
            temp = Regex.Split(File.ReadAllText("L2.txt"), @" ");
            foreach (var item in temp)
            {
                L2.Add(Convert.ToInt32(item));
            }
            Show(L1);
            Show(L2);
            foreach (var item in L2)
            {
                bool isInserted = false;
                for (int i = 0; i < L1.Count; i++)
                {
                    if (item >= L1[i])
                    {
                        L1.Insert(i, item);
                        isInserted = true;
                        break;
                    }
                }
                if (!isInserted)
                {
                    L1.Add(item);
                }
                
            }
            File.WriteAllText("Result.txt", ListToStr(L1));
        }
        static string ListToStr(List<int> li)
        {
            string str = "";
            int i = 0;
            int j = 0;
            foreach (var item in li)
            {
                str += item.ToString();
                i++;
                j++;
                if (i == 8)
                {
                    i = 0;
                    str += "\n";
                    continue;
                }
                if (j == li.Count)
                {
                    continue;
                }
                str += " ";
            }
            return str;
        }
        static void Show(List<int> li)
        {
            foreach (var item in li)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();
        }
    }
}

