using System;

namespace Lab_12._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Random rnd = new Random();
            Console.Write("Кільскість тварин: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Animal[] arr = new Animal[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("1 - Собака | 2 - Кіт: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                { 
                    Console.WriteLine("Ім'я, Порода");
                    arr[i] = new Dog(Convert.ToBoolean(rnd.Next(0, 2)), Console.ReadLine(), Console.ReadLine(), Convert.ToBoolean(rnd.Next(0, 2)));
                }
                else
                {
                    Console.WriteLine("Ім'я, Порода");
                    arr[i] = new Cat(rnd.Next(5, 15), Console.ReadLine(), Console.ReadLine(), Convert.ToBoolean(rnd.Next(0, 2)));
                }
            }
            for (int i = 0; i < n; i++)
            {
                arr[i].Show();
            }
            Console.WriteLine("***********************Пошук***********************");
            Console.Write("Ввеідть дату у форматі дд.мм.рррр ");
            string forSearch = Console.ReadLine();
            int j = 0;
            foreach (var el in arr)
            {
                if (el.DateOfVet == forSearch)
                {
                    el.Show();
                    j++;
                }
            }
            if (j==0)
            {
                Console.WriteLine("Таких немає");
            }
            Dog dog = new Dog(true, "ho", "hi", true);
            Cat cat = new Cat(45, "ki", "ko", false);
            cat.Call("ki");
            cat.Call("ko");
            cat.Command("sit");
            dog.Call("body");
            dog.Command("sit");
        }
    }
}
