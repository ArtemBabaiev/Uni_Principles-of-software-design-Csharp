using System;

namespace Lab__13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int repit = 1;
            do
            {
                Console.Write("Введіть номер дня тижня: ");
                int k = Convert.ToInt32(Console.ReadLine());
                GetCurriculum(k);
                Console.Write("0 - закінчити, 1 - ще раз\nВвід: ");
                repit = Convert.ToInt32(Console.ReadLine());
            } while (repit != 0);
        }
        static void GetCurriculum(int day)
        {
            switch (day)
            {
                case (int)Days.Mon:
                    Console.WriteLine("Математика – 4 уроки, Інформатика – 2 уроки");
                    break;
                case (int)Days.Tue:
                    Console.WriteLine("Мова – 4 уроки, Література – 2 уроки");
                    break;
                case (int)Days.Wen:
                    Console.WriteLine("Біологія – 3 уроки, Хімія – 3 уроки");
                    break;
                case (int)Days.Thu:
                    Console.WriteLine("Історія – 3 уроки, Географія – 3 уроки");
                    break;
                case (int)Days.Fri:
                    Console.WriteLine("Фізика – 3 уроки, Математика – 2 уроки");
                    break;
                case (int)Days.Sat:
                    Console.WriteLine("Спортивні гуртки – 4 уроки");
                    break;
                case (int)Days.Sun:
                    Console.WriteLine("Вихідний день");
                    break;
            }
        }
    } 
}
