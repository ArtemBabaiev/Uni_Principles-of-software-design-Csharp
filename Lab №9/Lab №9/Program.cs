using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lab__9
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool repit = true;
            while (repit)
            {
                Console.WriteLine();
                Console.Write("Введіть завдання: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    default:
                        repit = false;
                        break;
                }
            }
        }
        static void Task1()
        {
            File.WriteAllText("TF_1.txt", "");
            File.WriteAllText("TF_2.txt", "");
            string[] Symbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
                "x", "y", "z", " ", ",", ".", ";", ":", "_", "\n" };
            Random rnd = new Random();
            Console.Write("Введіть кількість символів: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string words = "";
            for (int i = 0; i < num; i++)
            {
                words += Symbols[rnd.Next(0, Symbols.Length)];
            }
            File.AppendAllText("TF_1.txt", words);
            string[] text1 = File.ReadAllLines("TF_1.txt");
            for (int i = 0; i < text1.Length; i++)
            {
                File.AppendAllLines("TF_2.txt", Regex.Split(text1[i], @"[ _\.\,\;\:]"));
            }
            string[] text2 = File.ReadAllLines("TF_2.txt");
            Console.WriteLine("Вміст файлу TF_2");
            foreach (var el in text2)
            {
                Console.WriteLine($"\t{el}");
            }
            Console.WriteLine("Завдання 1 завершено");
        }

        static void Task2()
        {
            File.WriteAllText("file_1.txt", "");
            File.WriteAllText("file_2.txt", "");
            string[] Symbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
                "x", "y", "z", "\n", "(", ")"};
            Random rnd = new Random();
            Console.Write("Введіть кількість символів: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                File.AppendAllText("file_1.txt", Symbols[rnd.Next(0, Symbols.Length)]);
            }
            string[] text = File.ReadAllLines("file_1.txt");
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = text[i].Replace('(', '*');
                text[i] = text[i].Replace(')', '#');
            }
            File.AppendAllLines("file_2.txt", text);
            Console.WriteLine("Завдання 2 завершено");
        }
        static void Task3()
        {
            string toExit;
            do
            {
                File.WriteAllText("expression.txt", "");
                Console.WriteLine("\nВведіть вираз до файлу та збережіть файл");
                string toCont;
                do
                {
                    Console.Write("Введіть \"continue\" для продовження: ");
                    toCont = Console.ReadLine();
                } while (toCont != "continue");
                string expr = File.ReadAllText("expression.txt");

                if (expr.Length != 0)
                {
                    if (Regex.Matches(expr, @"[^0-9\+\-\/\*]").Count != 0)
                    {
                        Console.WriteLine("У виразі містяться недопустимі символи");
                    }
                    else
                    {
                        if (Regex.Matches(expr, @"[\+\-\/\*]").Count == 0)
                        {
                            Console.WriteLine("Знак операції пропущенo");
                        }
                        else if (Regex.Matches(expr, @"[\+\-\/\*]").Count > 1)
                        {
                            Console.WriteLine("Вираз повинен містити одну операцію");
                        }
                        else
                        {
                            string symb = Regex.Match(expr, @"[\+\-\/\*]").ToString();
                            bool zeroDiv = false;
                            double result = 0;
                            switch (symb)
                            {
                                case "+":
                                    result = Convert.ToDouble(expr.Substring(0, expr.IndexOf("+"))) + Convert.ToDouble(expr.Substring(expr.IndexOf("+") + 1));
                                    break;
                                case "-":
                                    result = Convert.ToDouble(expr.Substring(0, expr.IndexOf("-"))) - Convert.ToDouble(expr.Substring(expr.IndexOf("-") + 1));
                                    break;
                                case "*":
                                    result = Convert.ToDouble(expr.Substring(0, expr.IndexOf("*"))) * Convert.ToDouble(expr.Substring(expr.IndexOf("*") + 1));
                                    break;
                                case "/":
                                    try
                                    {
                                        result = Convert.ToDouble(expr.Substring(0, expr.IndexOf("/"))) / Convert.ToDouble(expr.Substring(expr.IndexOf("/") + 1));
                                    }
                                    catch (DivideByZeroException)
                                    {
                                        Console.WriteLine("Ділення на нуль неможливе");
                                        zeroDiv = true;
                                    }
                                    break;
                            }
                            if (zeroDiv)
                            {
                                File.AppendAllText("expression.txt", "\nРезультат не визначений");
                            }
                            else
                            {
                                Console.WriteLine("Результат занесено до файлу");
                                File.AppendAllText("expression.txt", $"\nРезультат = {result}");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вираз не введено");
                }
                Console.Write("Введіть \"exit\" для виходу: ");
                toExit = Console.ReadLine();
            } while (toExit != "exit");
            Console.WriteLine("Завдання 3 завершено");
        }
    }
}
