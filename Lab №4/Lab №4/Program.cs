using System;

namespace Lab__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool repit = true;
            int number;
            while (repit)
            {
                Console.Write("\nНомер завдання: ");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number) 
                {
                    case 1:
                        double a1, a2, a3;
                        Console.Write("Введіть довжину першої сторони ");
                        a1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть довжину другої сторони ");
                        a2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть довжину третьої сторони ");
                        a3 = Convert.ToDouble(Console.ReadLine());
                        if (a1+a2>a3 && a1+a3>a2 && a2 + a3 > a1)
                        {
                            Console.WriteLine("Площа трикутника " + areaOfTriangle(a1, a2, a3).ToString());
                        }
                        else
                        {
                            Console.WriteLine("Такого трикутника не існує");
                        }
                        break;
                    case 2:
                        double a, b, u;
                        Console.Write("Введіть a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введіть b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        u = func(a, b, 0);
                        Console.WriteLine("Значення виразу: " + u.ToString());
                        break;
                    case 3:
                        Console.Write("Введіть вимір: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int[] Va = new int [n];
                        int[] Vb = new int[n];
                        int[] Vc = new int[n];
                        Console.WriteLine("Введіть елементи вектора а ");
                        SetArray(Va, n);
                        Console.WriteLine("Введіть елементи вектора b ");
                        SetArray(Vb, n);
                        Console.WriteLine("Введіть елементи вектора c ");
                        SetArray(Vc, n);
                        Console.Write("A = ");
                        PrintArray(Va, n);
                        Console.Write("B = ");
                        PrintArray(Vb, n);
                        Console.Write("C = ");
                        PrintArray(Vc, n);
                        Console.WriteLine("Скалярний добуток: " + (2 * vec(Va, Vb, n, 0) - 3 * vec(Va, Vc, n, 0)).ToString());
                        break;
                    default:
                        repit = false;
                        break;

                }

            }
        }
        static double areaOfTriangle(double a, double b, double c)
        {
            double s, p;
            p = (a + b + c) / 2.0;
            s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }

        static double func(double x, double y, int i)
        {
            double f;
            if (x > y)
            {
                f = Math.Pow(x, 3) + Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 4));    
            }
            else
            {
                if (x > 0)
                {
                    f = (Math.Pow(x, 2.0) - 2 * x + Math.Sqrt(x)) / Math.Pow(x, 3.0 / 5);
                }
                else
                {
                    Console.WriteLine("Першу операію пропущенно через x = 0 або x < 0");
                    i++;
                    return func(2, x, i) + 2;
                }
            }
            if (i == 1)
            {
                Console.WriteLine(f);
                return f;
            }
            i++;
            Console.WriteLine(f);
            return f + func(2, x, i) + 2;
        }


        static int[] SetArray(int[] arr, int n)
        {
            for (int i = 0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static void PrintArray(int[] arr, int n)
        {
            Console.Write("{ ");
            for (int i = 0; i<n; i++)
            {
                Console.Write(arr[i].ToString());
                if (i < n - 1)
                {
                    Console.Write(" | ");
                }
            }
            Console.WriteLine(" }");
        }

        static int vec(int[] ar1, int[] ar2, int n , int j)
        {
            int product;
            if (j < n)
            {
                product = ar1[j] * ar2[j];
            }
            else
            {
                return 0;
            }

            return product + vec(ar1, ar2, n, j + 1);
        }
    }
}
