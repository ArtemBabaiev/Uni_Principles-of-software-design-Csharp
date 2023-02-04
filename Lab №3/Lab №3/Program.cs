using System;

namespace Lab__3
{
    class Program
    {
        public const double MaxValue = 1.7976931348623157E+308;
        public const double MinValue = -1.7976931348623157E+308;
        static void Main(string[] args)
        {
            bool restart = true;
            int n;
            while (restart)
            {
                Console.Write("Введiть номер завдання: ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Task_1();
                        break;
                    case 2:
                        Task_2();
                        break;
                    case 3:
                        Task_3();
                        break;
                    case 4:
                        Task_4();
                        break;
                    case 5:
                        Task_5();
                        break;
                    default:
                        Console.WriteLine("Виконання завдяання завершено");
                        restart = false;
                        break;

                }
            }
        }

        static void Task_1()
        {
            Console.WriteLine("_______________________________part 1________________________________");
            Console.Write("Введiть N: ");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Введiть a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a != 0 && a != -n)
            {
                double denominator = a;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    double numerator = 2 * (i + 1);
                    sum += numerator / denominator;
                    denominator *= (a + (i + 1));
                }
                Console.WriteLine("Сума: " + sum.ToString());
            }
            else if (a == 0)
            {
                Console.WriteLine("Операцiя не можлива a = 0");
            }
            else if (a == -n)
            {
                Console.WriteLine("Операцiя не можлива a = -n");
            } 
        }

        static void Task_2()
        {
            Console.WriteLine("_______________________________part 2________________________________");

            int oneToK, x, k;
            double numerator, denominator, fact, sumOfElements;

            //bool isFactOK = true; 
            Console.Write("Введiть епсiлон: ");
            double eps = Convert.ToDouble(Console.ReadLine());
            x = 1;
            sumOfElements = 0;
            while (x <= 5)
            {
                k = 0;
                fact = 1;
                oneToK = -1;
                numerator = oneToK * Math.Pow(x, 2 * k - 1);
                denominator = (2 * k + 1) * fact;
                double element = numerator / denominator;
                while (Math.Abs(element) >= eps)
                {
                    //Console.WriteLine(x.ToString() +  " | " + k.ToString() + " | " + element.ToString());
                    sumOfElements += element;
                    k += 1;
                    fact *= k;
                    if (fact > MaxValue || fact < MinValue)
                    {
                        Console.WriteLine("\nOverflow fact");
                        break;
                    }
                    else
                    {
                        oneToK *= -1;
                        numerator = oneToK * Math.Pow(x, 2 * k - 1);
                        if (numerator > MaxValue || numerator < MinValue)
                        {
                            Console.WriteLine("\nOverflow numerator");
                            break;
                        }
                        else
                        {
                            denominator = (2 * k + 1) * fact;
                            element = numerator / denominator;
                        }
                            
                        
                    }
                    
                }
                x += 1;
            }
            Console.WriteLine("Сума: " + sumOfElements.ToString());
        }
        static void Task_3()
        {
            Console.Write("Введiть довжину радiуса: ");
            double radius = Math.Abs(Convert.ToDouble(Console.ReadLine()));
            string table = " №\tКоординати\tРезультат\n";
            double x, y;
            

            for (int i =0; i<10; i++)
            {
                Console.WriteLine((i+1).ToString() + " пострiл");
                Console.Write("\tx = ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("\ty = ");
                y = Convert.ToDouble(Console.ReadLine());
                double radiusToPoint = x * x + y * y;
                if (((x >= 0 && y >= 0) || (x < 0 && y < 0)) && (radiusToPoint <= radius * radius))
                {
                    if (Math.Abs(y) >= Math.Abs(x))
                    {
                        table = table + " " + (i + 1).ToString() + "\t";
                        table = table  + (x).ToString() + ";" + (y).ToString() + "\t\t";
                        table = table + "Влучив\n";
                    }
                    else
                    {
                        table = table + " " + (i + 1).ToString() + "\t";
                        table = table + (x).ToString() + ";" + (y).ToString() + "\t\t";
                        table = table + "Не влучив\n";
                    }
                }
                else
                {
                    table = table + " " + (i + 1).ToString() + "\t";
                    table = table + (x).ToString() + ";" + (y).ToString() + "\t\t";
                    table = table + "Не влучив\n";
                }
            }
            Console.WriteLine(table);
            
        }

        static void Task_4()
        {
            int x = 10;
            for (int i = x; i>0; i--)
            {
                for (int j=0; j<2; j++)
                {
                    Console.WriteLine(i.ToString() + " green bottles hanging on the wall,");
                }
                Console.WriteLine("And if one green bottle should accidentally fall,\n" + "There\'ll be " + (i - 1).ToString() + "green bottles hanging on the wall.\n");
            }
                
        }
        static void Task_5()
        {
            Console.Write("Введiть масу однiєї зернини: ");
            double massOfGrain = Convert.ToDouble(Console.ReadLine());
            ulong n = 1;
            ulong sumOfGrains = 1;
            Console.WriteLine("1 ячейкa | " + n.ToString() );
            for (int i = 0; i<63; i++)
            {
                n *= 2;
                sumOfGrains += n;
                Console.WriteLine((i+2).ToString() + " ячейкa | " + n.ToString() );
            }
            Console.WriteLine("\nЗагальна кiлькiсть зерен " + sumOfGrains.ToString());
            Console.WriteLine("Маса зерна: " + (massOfGrain * sumOfGrains).ToString() + '\n');
        }
    }
}















































/*
                    try
                    {
                        fact *= k;
                    }
                    catch (StackOverflowException)
                    {
                        isFactOK = false;
                    }
                    if (isFactOK == false)
                    {
                        break;
                    }
                    else
                    {
                    
                        fact *= k;
                        Console.WriteLine(fact);
                        oneToK *= -1;
                        numerator = oneToK * Math.Pow(x, 2 * k - 1);
                        denominator = (2 * k + 1) * fact;
                        element = numerator / denominator;
                        
                    }
 */