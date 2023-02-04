using System;

namespace Lab__14._3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Random rnd = new Random();

            LoopList<ShopMan> people = new LoopList<ShopMan>();
            LoopList<string> products = new LoopList<string>();

            products.Add("fruit");
            products.Add("bread");
            products.Add("milk");
            products.Add("water");
            products.Add("meat");
            products.Add("pepper");
            products.Add("vegetables");
            products.Add("salt");
            products.Add("sugar");
            products.Add("flour");
            for (int i = 0; i < 3; i++)
            {
                people.Add(new ShopMan(RanStr(), rnd.Next(1, 5)));
            }
            foreach (var item in people)
            {
                Console.WriteLine($"Покупець {item.Name}");
                foreach (var el in products)
                {
                    Console.Write($"Чи купити {el} (Y - так; N - ні): ");
                    if (Console.ReadLine() == "Y")
                    {
                        if (item.NumToBuy==0)
                        {
                            Console.WriteLine("Цей покупець купив максимальну кількість");
                            break;
                        }
                        item.AddToCart(el);
                    }
                }
                Console.Write("Закінчити покупки (Y - так; N - ні): ");
                if (Console.ReadLine() == "Y")
                {
                    break;
                }
            }

            people.PrintShoppers();

        }
        static string RanStr()
        {
            string[] Symbols = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
                "x", "y", "z"};
            Random rnd = new Random();
            string words = "";
            for (int i = 0; i < 4; i++)
            {
                words += Symbols[rnd.Next(0, Symbols.Length)];
            }

            return words;
        }
    }
}
