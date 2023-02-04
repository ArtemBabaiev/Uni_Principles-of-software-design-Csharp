using Lab__13._1;
using System;

namespace Lab__14._5
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random rnd = new Random();

            var lst = new Linked1<Student>();
            for (int i = 0; i < 3; i++)
            {
                int[] Marks = new int[] { rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6), rnd.Next(1, 6) };
                lst.MyAddLast(new Student(RanStr(), rnd.Next(10, 20), Marks));
            }
            lst.MyPrint();
            Console.WriteLine("Введіть параметри");
            Console.Write("Ім'я: ");
            string Tname = Console.ReadLine();
            Console.Write("Група: ");
            int Tgroup = Convert.ToInt32(Console.ReadLine());
            lst.MyRemove(new Student(Tname, Tgroup, new int[5]));
            lst.MyPrint();
            if (lst.MySearch(new Student(Tname, Tgroup, new int[5])))
            {
                Console.WriteLine("Елемент наявний");
            }
            else
            {
                Console.WriteLine("Елемент відсутній");
            }
            Console.WriteLine("Введіть параметри");
            Console.Write("Ім'я: ");
            Tname = Console.ReadLine();
            Console.Write("Група: ");
            Tgroup = Convert.ToInt32(Console.ReadLine());
            if (lst.MySearch(new Student(Tname, Tgroup, new int[5])))
            {
                Console.WriteLine("Елемент наявний");
            }
            else
            {
                Console.WriteLine("Елемент відсутній");
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
