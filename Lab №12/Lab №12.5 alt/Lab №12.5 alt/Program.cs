using System;

namespace Lab__12._5_alt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random rnd = new Random();

            Console.Write("Кількість дерев: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Trees arrTrees = new Trees();
            Tree[] arr = new Tree[n];

            for (int i = 0; i < n; i++)
            {
                var temp = new Tree(RandomString(), rnd.Next(100, 500), rnd.Next(100, 500));
                arrTrees.AddTree(temp);
                arr[i] = temp;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nСортування за висотою і ціною");
            Array.Sort(arr, new TreeComparator());
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("\nСортування за ціною");
            arrTrees.SortByPrice();
            foreach (var item in arrTrees)
            {
                Console.Write(item.Species + " | ");
            }
            Console.WriteLine("\n");
        }

        static public string RandomString()
        {
            string result = "";
            string[] Symbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
                "x", "y", "z" };
            Random rnd = new Random();
            int n = rnd.Next(3, 6);
            for (int i = 0; i < n; i++)
            {
                result += Symbols[rnd.Next(0, Symbols.Length)];
            }
            return result;
        }
    }
}
