using System;

namespace Lab__13._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            GetCost("art", (150, 45, 56, 78, 79, 45), 450);
        }
        
        static void GetCost(string ownerCar, (int, int, int, int, int, int) priceSparepart, int priceInspection)
        {
            double average = 0;
            average += priceSparepart.Item1;
            average += priceSparepart.Item2;
            average += priceSparepart.Item3;
            average += priceSparepart.Item4;
            average += priceSparepart.Item5;
            average += priceSparepart.Item6;
            average = average / 6;
            double invoice = Math.Round(0.7 * average + 0.95 * priceInspection, 2);
            Console.WriteLine($"Клієнт {ownerCar} – ваша ціна до оплати становить {invoice}");
        }
    }
}
