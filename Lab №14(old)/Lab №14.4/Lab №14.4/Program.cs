using Lab__10._3;
using System;

namespace Lab__14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random rand = new Random();
            
            Console.Write("Введіть кількість комп'ютерів: ");
            int num = Convert.ToInt32(Console.ReadLine());
            MyList<Computer> lst = new MyList<Computer>(num);
            for (int i = 0; i < num; i++)
            {
                lst.MyAdd(new Computer(RanStr()+ "-i" + rand.Next(3, 7).ToString(), rand.Next(100, 999), RanStr(), rand.Next(1, 16), rand.Next(1, 16), rand.Next(100, 999), Convert.ToBoolean(rand.Next(0, 2))));           
            }
            foreach (var item in lst)
            {
                item.PrintChar();
            }
            Console.WriteLine("******************************************************************************");
            lst.MyAdd(new Computer("new 1", rand.Next(100, 999), RanStr(), rand.Next(1, 16), rand.Next(1, 16), rand.Next(100, 999), Convert.ToBoolean(rand.Next(0, 2))));
            lst.MyAdd(new Computer("new 2", rand.Next(100, 999), RanStr(), rand.Next(1, 16), rand.Next(1, 16), rand.Next(100, 999), Convert.ToBoolean(rand.Next(0, 2))));
            foreach (var item in lst)
            {
                item.PrintChar();
            }
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
