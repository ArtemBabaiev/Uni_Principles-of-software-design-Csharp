using System;

namespace Lab__12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random rnd = new Random();
            Console.Write("Кількість дерев");
            int n = Convert.ToInt32(Console.ReadLine());
            Tree[] arr = new Tree[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Tree(RandomString(), rnd.Next(1, 500), rnd.Next(1, 500));
            }
            Console.WriteLine("1-ше Сортування");
            Array.Sort(arr, new CompareTree());
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("2-ге Сортування");
            Array.Sort(arr);


            var enumerator = arr.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }
        }






        static public string RandomString()
        {
            string result = "";
            string[] Symbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
                "x", "y", "z" };
            Random rnd = new Random();
            int n = rnd.Next(1, 6);
            for (int i = 0; i < n; i++)
            {
                result += Symbols[rnd.Next(0, Symbols.Length)];
            }
            return result;
        }
    }
}
