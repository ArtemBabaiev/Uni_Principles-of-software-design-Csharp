using Lab__13._1;
using System;
using System.Collections;

namespace Lab__14._6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            ArrayList arr = new ArrayList();
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                int[] Marks = new int[] { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) };
                arr.Add(new Student(RanStr(), rnd.Next(10, 20), Marks));
            }
            Console.WriteLine($"Кількість елементів: {arr.Count}");
            arr.Clear();
            Console.WriteLine($"Кількість елементів: {arr.Count}");
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
    }
}
