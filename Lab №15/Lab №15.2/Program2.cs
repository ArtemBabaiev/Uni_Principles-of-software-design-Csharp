using System;

namespace Lab__15._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Random rnd = new Random();

            DoubleQueue<int> que = new DoubleQueue<int>();
            Console.Write("Введіть початкову кількість елементів: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                que.PushBack(rnd.Next(10, 100));
            }
            foreach (var item in que)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();
            que.PushFront(1);
            que.PushFront(2);
            que.PopBack();
            que.PushBack(999);
            que.PopFront();

            foreach (var item in que)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine();

            Console.WriteLine($"Довжина {que.Size}");
            Console.WriteLine($"Перший елемент {que.Front}");
            Console.WriteLine($"Останній елемент {que.Back}");

            que.Clear();
            Console.WriteLine($"Довжина після видалення {que.Size}");
        }
    }
}
