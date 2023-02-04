using System;

namespace Lab__11._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var mat1 = new MatrixInt(3, 3, 7);
            var mat2 = new MatrixInt(3, 2, 5);
            Console.WriteLine("Початкові матриці");
            mat1.PrintMatrix();
            Console.WriteLine("********************************");
            mat2.PrintMatrix();

            Console.WriteLine("Поелементне перезадання матриці");
            mat1.SetElements();
            mat1.PrintMatrix();
            Console.WriteLine("Зміна значень вектора скаляром 9");
            mat2.SetWithParametr(5);

            Console.WriteLine($"Кількість створених матриц {MatrixInt.Quantity()}");
            mat1.CodeError = 0;
            Console.WriteLine($"Індексатор читання {mat1[5]}");
            Console.WriteLine($"Код помилки: {mat1.CodeError}");

            Console.WriteLine("Перевірка ++ та --");
            mat1--;
            mat2++;
            mat1.PrintMatrix();
            Console.WriteLine("********************************");
            mat2.PrintMatrix();

            Console.WriteLine("Перевірка true, false");
            if (mat1)
            {
                Console.WriteLine("True 1");
            }
            else
            {
                Console.WriteLine("False 1");
            }

            Console.WriteLine("Перевірка !");
            if (!mat2)
            {
                Console.WriteLine("Масив заповнений");
            }
            else
            {
                Console.WriteLine("Масив пустий");
            }

            Console.WriteLine("Перевірка ~");
            int[] size = mat2.Size;
            int[,] a = ~mat2;
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Перевірка +");
            var resADD = mat1 + mat2;
            resADD.PrintMatrix();
            resADD += 2;
            resADD.PrintMatrix();

            Console.WriteLine("Перевірка -");
            var resSUB = mat1 - mat2;
            resSUB.PrintMatrix();
            Console.WriteLine();
            resSUB -= 2;
            resSUB.PrintMatrix();

            Console.WriteLine("Перевірка *");
            var resMUL = mat1 * mat2;
            resMUL.PrintMatrix();
            Console.WriteLine();
            resMUL *= 2;
            resMUL.PrintMatrix();
            Console.WriteLine();
            var mat3 = new MatrixInt(3, 3, 7);
            var vec = new VectorInt(3, 2);
            var resMATVEC = mat3 * vec;
            resMATVEC.PrintMatrix();

            Console.WriteLine("Перевірка /");
            var resDIV = mat1 / mat2;
            resDIV.PrintMatrix();
            Console.WriteLine();
            resDIV /= 2;
            resDIV.PrintMatrix();

            Console.WriteLine("Перевірка %");
            var resOST = mat1 % mat2;
            resOST.PrintMatrix();
            Console.WriteLine();
            resOST %= 2;
            resOST.PrintMatrix();

            Console.WriteLine("Перевірка |");
            var resbitADD = mat1 | mat2;
            resbitADD.PrintMatrix();
            Console.WriteLine();
            resbitADD |= 2;
            resbitADD.PrintMatrix();

            Console.WriteLine("Перевірка &");
            var resbitMUL = mat1 & mat2;
            resbitMUL.PrintMatrix();
            Console.WriteLine();
            resbitMUL &= 2;
            resbitMUL.PrintMatrix();

            Console.WriteLine("Перевірка ^");
            var resbitAD2 = mat1 ^ mat2;
            resbitAD2.PrintMatrix();
            Console.WriteLine();
            resbitAD2 ^= 2;
            resbitAD2.PrintMatrix();

            Console.WriteLine("Перевірка >>");
            mat1.PrintMatrix();
            var resbitSHFR = mat1 >> 2;
            resbitSHFR.PrintMatrix();

            Console.WriteLine("Перевірка <<");
            mat1.PrintMatrix();
            var resbitSHFL = mat1 << 2;
            resbitSHFL.PrintMatrix();

            Console.WriteLine("Перевірка порівнянь");
            if (mat1 == mat2)
            {
                Console.WriteLine("== true");
            }
            else
            {
                Console.WriteLine("== false");
            }

            if (mat1 != mat2)
            {
                Console.WriteLine("!= true");
            }
            else
            {
                Console.WriteLine("!= false");
            }

            if (mat1 > mat2)
            {
                Console.WriteLine("> true");
            }
            else
            {
                Console.WriteLine("> false");
            }
            if (mat1 < mat2)
            {
                Console.WriteLine("< true");
            }
            else
            {
                Console.WriteLine("< false");
            }
            if (mat1 >= mat2)
            {
                Console.WriteLine(">= true");
            }
            else
            {
                Console.WriteLine(">= false");
            }
            if (mat1 <= mat2)
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
