using System;
using System.Text.RegularExpressions;

namespace Lab__8
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
                Console.WriteLine();
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
                    case 4:
                        Task4();
                        break;
                    default:
                        repit = false;
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.WriteLine("Підзавдання 1");
            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привіт, {name}");

            Console.WriteLine("\nПідзавдання 2");
            Console.Write("Введіть рядок 1: ");
            string str1 = Console.ReadLine();
            Console.Write("Введіть рядок 2: ");
            string str2 = Console.ReadLine();
            string result2 = str1.Substring(0, 2) + str2.Substring(str2.Length-1);
            Console.WriteLine($"Результат {result2}");

            Console.WriteLine("\nПідзавдання 3");
            string apple = "Яблуко";
            string result3 = apple.Substring(1, 2) + apple[apple.Length - 1] + apple[apple.Length - 2];
            Console.WriteLine($"Результат {result3}");

            Console.WriteLine("\nПідзавдання 4");
            Console.Write("Введіть рядок 1: ");
            string str4 = Console.ReadLine();
            str4 = str4.Replace(" ", "_");
            Console.WriteLine($"Результат {str4}");
        }

        static void Task2()
        {
            Regex pattern = new Regex(@"[0-3][0-9]\.[0-1][0-9]\.[1-2][90][0-9][0-9]");
            string str = "qwerty 18.07.2002 asdfg18,07.2002 asd 18u07.2002 qse 18.07.2020";
            Console.WriteLine($"Вхідні: {str}");
            var allIn = pattern.Matches(str);
            int counter = 0;
            Console.WriteLine("Знайшли");
            foreach (Match match in allIn) 
            {
                counter++;
                Console.WriteLine($"\t {match}");
            }
            Console.WriteLine($"Кількість входжень {counter}");
            for(int i = 0; i < counter; i++)
            {
                Console.WriteLine($"Співпадіння: {allIn[i]}");
                Console.WriteLine("0-Залишити\n1-Вилучити\n2-Замінити");
                Console.Write("Вибір: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        str = str.Replace(allIn[i].ToString(), "");
                        break;
                    case 2:
                        Console.Write("Введіь заміну: ");
                        str = str.Replace(allIn[i].ToString(), Console.ReadLine());
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Результат: {str}");

        }

        static void Task3()
        {
            string text = "Еней був парубок моторний\nІ хлопець хоть куди козак,\nУдавсь на всеє зле проворний,\nЗавзятіший од всіх бурлак";
            Console.WriteLine(text);
            Console.Write("Введіть слово: ");
            string word = Console.ReadLine();
            Regex pattern = new Regex(@word);
            bool result = pattern.IsMatch(text);
            Console.WriteLine($"Результат: {result}");

        }

        static void Task4()
        {
            string text1 = "computer: CPU, laptop: mouse, disk port";
            string text2 = "GPU; mouse! keyboard; laptop";
            Console.WriteLine($"Перший текст:\n\t{text1}");
            Console.WriteLine($"Другий текст:\n\t{text2}");
            string[] arr2 = Regex.Split(text2, @"[\ \.\,\:\;\-\!\?]");
            foreach (string elem in arr2)
            {
                text1 = Regex.Replace(text1, @elem, "");   
            }
            Console.WriteLine($"Результат: {text1}");
        }
    }
}