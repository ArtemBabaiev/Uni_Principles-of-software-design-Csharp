using System;

namespace Lab__11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var vec1 = new VectorInt(3);
            var vec2 = new VectorInt(5, 3);
            Console.WriteLine("Початкові вектори");
            vec1.PrintVector();
            vec2.PrintVector();

            Console.WriteLine("Поелементне перезадання вектора");
            vec2.SetElements();
            vec2.PrintVector();
            Console.WriteLine("Зміна значень вектора скаляром 5");
            vec1.SetWithParam(5);
            vec1.PrintVector();
            Console.WriteLine("Перезадання вектора вектором");
            vec1.SetWithVector(new int[] { 1, 2, 3, 4 });
            vec1.PrintVector();

            Console.WriteLine($"Кількість створених векторів {VectorInt.Quantity()}");
            Console.WriteLine($"Довжина вектора 1:{vec1.Size}. Довжина вектора 2:{vec2.Size}");
            vec1.CodeError = 0;
            Console.WriteLine($"Індексатор читання {vec1[100]}");
            Console.WriteLine($"Код помилки: {vec1.CodeError}");

            Console.WriteLine("Перевірка ++ та --");
            vec1--;
            vec2++;
            vec1.PrintVector();
            vec2.PrintVector();
            Console.WriteLine("Перевірка true, false");
            if (vec1)
            {
                Console.WriteLine("True 1");
            }
            else
            {
                Console.WriteLine("False 1");
            }

            Console.WriteLine("Перевірка !");
            if (!vec2)
            {
                Console.WriteLine("Масив заповнений");
            }
            else
            {
                Console.WriteLine("Масив пустий");
            }
            Console.WriteLine("Перевірка ~");
            int[] a = ~vec2;
            foreach (int item in a)
            {
                Console.Write(item.ToString() + " | ");
            }
            Console.WriteLine();
            Console.WriteLine("\n Перевірка ариф. операцій");
            vec1.PrintVector();
            vec2.PrintVector();
            Console.WriteLine("Перевірка +");
            var resADD = vec1 + vec2;
            resADD.PrintVector();
            resADD += 2;
            resADD.PrintVector();

            Console.WriteLine("Перевірка -");
            var resSUB = vec1 - vec2;
            resSUB.PrintVector();
            resSUB -= 2;
            resSUB.PrintVector();

            Console.WriteLine("Перевірка *");
            var resMUL = vec1 * vec2;
            resMUL.PrintVector();
            resMUL *= 2;
            resMUL.PrintVector();

            Console.WriteLine("Перевірка /");
            var resDIV = vec1 / vec2;
            resDIV.PrintVector();
            resDIV /= 2;
            resDIV.PrintVector();

            Console.WriteLine("Перевірка %");
            var resOST = vec1 / vec2;
            resOST.PrintVector();
            resOST /= 2;
            resOST.PrintVector();

            Console.WriteLine("Перевірка |");
            var resbitADD = vec1 | vec2;
            resbitADD.PrintVector();
            resbitADD |= 2;
            resbitADD.PrintVector();

            Console.WriteLine("Перевірка &");
            var resbitMUL = vec1 & vec2;
            resbitMUL.PrintVector();
            resbitMUL &= 2;
            resbitMUL.PrintVector();

            Console.WriteLine("Перевірка ^");
            var resbitAD2 = vec1 ^ vec2;
            resbitAD2.PrintVector();
            resbitAD2 ^= 2;
            resbitAD2.PrintVector();

            Console.WriteLine("Перевірка >>");
            vec1.PrintVector();
            var resbitSHFR = vec1 >> 2;
            resbitSHFR.PrintVector();

            Console.WriteLine("Перевірка <<");
            vec1.PrintVector();
            var resbitSHFL = vec1 << 2;
            resbitSHFL.PrintVector();

            Console.WriteLine("Перевірка порівнянь");
            if (vec1 == vec2)
            {
                Console.WriteLine("== true");
            }
            else
            {
                Console.WriteLine("== false");
            }

            if (vec1 != vec2)
            {
                Console.WriteLine("!= true");
            }
            else
            {
                Console.WriteLine("!= false");
            }

            if (vec1 > vec2)
            {
                Console.WriteLine("> true");
            }
            else
            {
                Console.WriteLine("> false");
            }
            if (vec1 < vec2)
            {
                Console.WriteLine("< true");
            }
            else
            {
                Console.WriteLine("< false");
            }
            if (vec1 >= vec2)
            {
                Console.WriteLine(">= true");
            }
            else
            {
                Console.WriteLine(">= false");
            }
            if (vec1 <= vec2)
            {
                Console.WriteLine("<= true");
            }
            else
            {
                Console.WriteLine("<= false");
            }
        }

    }
}
