using System;

namespace Lab__13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var rnd = new Random();
            (string[], double[], int[], int[]) Figures;

            Console.Write("Введіть кількість учасників: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] tempName = new string[num];
            double[] tempMark = new double[num];
            int[] tempAge = new int[num];
            int[] tempa = new int[num];
            double average = 0;
            for (int i = 0; i < num; i++)
            {
                tempName[i] = RanStr();
                double temp = Math.Round(rnd.NextDouble() * 10, 3);
                tempMark[i] = temp;
                tempAge[i] = rnd.Next(16, 35);
                average += temp;
                tempa[i] = rnd.Next(10, 60);
                //Console.WriteLine($"{tempName[i]} | {tempMark[i]} | {tempAge[i]} | {tempa[i]}");
            }
            average = Math.Round(average / num, 2);
            Console.WriteLine($"Середне значення: {average}");
            Figures = (tempName, tempMark, tempAge, tempa);
            Console.WriteLine("********************************Таблиця********************************");
            PrintAll(Figures);
            Console.WriteLine("********************************Кінець  табл********************************");
            int numOfPeople = 0;
            for (int i = 0; i < num; i++)
            {
                if (Figures.Item2[i] > average)
                {
                    PrintEl(Figures, i);
                    numOfPeople++;
                }
            }
            Console.WriteLine($"Кваліфікацію пройшло {numOfPeople} людини");
        }

        static string RanStr()
        {
            string[] Symbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
                "x", "y", "z"};
            Random rnd = new Random();
            string words = "";
            for (int i = 0; i < 5; i++)
            {
                words += Symbols[rnd.Next(0, Symbols.Length)];
            }

            return words;
        }

        static void PrintAll((string[], double[], int[], int[]) tpl)
        {
            
            foreach (var item in tpl.Item1)
            {
                    Console.Write(item + "\t");
            }
            Console.WriteLine();
            foreach (var item in tpl.Item2)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            foreach (var item in tpl.Item3)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            foreach (var item in tpl.Item4)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
        static void PrintEl((string[], double[], int[], int[]) tpl, int num)
        {
            Console.WriteLine($"{ tpl.Item1[num]} | {tpl.Item2[num]} | {tpl.Item3[num]} | {tpl.Item4[num]}");

        }
    }
}
