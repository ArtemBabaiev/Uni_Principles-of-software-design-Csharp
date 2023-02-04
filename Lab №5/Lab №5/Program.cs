using System;

namespace Lab__5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool repit = true;
            int k, n, i, j;
            while (repit)
            {
                Console.Write("Введіть номер завдання ");
                k = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("________________________________________START______________________________________________");
                switch (k)
                {
                    case 1:
                        Console.Write("Введіть розмір масиву ");
                        n = Convert.ToInt32(Console.ReadLine());
                        int[] Task1Array = new int[n];
                        Task1Array = Set_1d_array(n, false);
                        Console.Write("Масив до зміни:\n\t");
                        print_1d(Task1Array);
                        Console.Write("Введіть число ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (i = 0; i < n; i++)
                        {
                            if (Task1Array[i] < num)
                            {
                                Task1Array[i] = num;
                            }
                        }
                        Console.Write("Масив після заміни:\n\t");
                        print_1d(Task1Array);
                        break;

                    //►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►
                    case 2:
                        n = 20;
                        int[] Task2Array = new int[n];
                        Task2Array = Set_1d_array(n, true);
                        Console.Write("Масив до зміни:\n\t");
                        print_1d(Task2Array);
                        for (i = 0; i<n; i++)
                        {
                            if (Task2Array[i] > 0)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    if (Task2Array[i] == -Task2Array[j])
                                        Task2Array[j] = -Task2Array[j];
                                }   
                            }   
                        }
                        Console.Write("Масив після заміни:\n\t");
                        print_1d(Task2Array);
                        break;

                    //►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►
                    case 3:
                        Console.Write("Введіть розмір масиву ");
                        n = Convert.ToInt32(Console.ReadLine());
                        int[,] Task3Array = new int[n, n];
                        int[] X = new int[n];
                        Task3Array = Set_2d_array(n, n, true);
                        Console.WriteLine("Матриця A:");
                        print_2d(Task3Array, n, n);
                        int over = OverDiagonal(Task3Array, n);
                        int under = UnderDiagonal(Task3Array, n);
                        //Console.WriteLine("O " + over.ToString() + " U " + under.ToString());
                        int actualLenght = 0;
                        for (i=0; i<n; i++)
                        {
                            if (Task3Array[i, i] < 0)
                            {
                                X[actualLenght] = under;
                                actualLenght++;
                            }
                            if (Task3Array[i, i] > 0)
                            {
                                X[actualLenght] = over;
                                actualLenght++;
                            }
                        }
                        Console.Write("Масив Х:\n\t");
                        for (i = 0; i < actualLenght; i++)
                        {
                            Console.Write(X[i].ToString() + " | ");
                        }
                        Console.WriteLine();
                        break;

                    //►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►
                    case 4:
                        int mainSize = 5, subSize = 4;
                        int maxElement, maxI, maxJ;

                        int[,] Task4Array = new int[mainSize, subSize];
                        Task4Array = Set_2d_array(mainSize, subSize, true);
                        print_2d(Task4Array, mainSize, subSize);

                        maxElement = -1;
                        maxI = -1;
                        maxJ = -1;
                        for (i = 0; i<mainSize; i++)
                        {
                            for (j = 0; j < subSize; j++)
                            {
                                if (Math.Abs(Task4Array[i,j]) >= maxElement)
                                {
                                    maxElement = Math.Abs(Task4Array[i,j]);
                                    maxI = i;
                                    maxJ = j;
                                }
                            }
                        }

                        Console.WriteLine("Максимальний елемент: " + maxElement.ToString());
                        Console.WriteLine("Координати: " + maxJ.ToString() + ";" + maxI.ToString());
                        break;

                    //►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►
                    case 5:
                        int numberOfEmployees = 18, numberOfMonth = 12;
                        int sumOfAll = 0, sumOfAprils = 0, averageForAprils;

                        int[,] Task5Array = new int[numberOfEmployees, numberOfMonth];
                        Task5Array = Set_2d_array(numberOfEmployees, numberOfMonth, true);
                        Console.WriteLine("\nJa\tFe\tMar\tAp\tMay\tJn\tJl\tAu\tSb\tOb\tNb\tDb");
                        print_2d(Task5Array, numberOfEmployees, numberOfMonth);

                        for (i = 0; i < numberOfEmployees; i++)
                        {
                            for (j = 0; j < numberOfMonth; j++)
                            {
                                sumOfAll += Task5Array[i, j];
                                if (j == 3)
                                {
                                    sumOfAprils += Task5Array[i, j];
                                }
                            }
                        }
                        averageForAprils = sumOfAprils / numberOfEmployees;

                        Console.WriteLine("Загальна бюджет: " + sumOfAll.ToString());
                        Console.WriteLine("Загальна зарплата за квітень: " + sumOfAprils.ToString());
                        Console.WriteLine("Середня платня за квітень: " + averageForAprils.ToString());

                        break;

                    //►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►
                    case 6:
                        Console.Write("Введіть розмір зовнішнього масиву: ");
                        int outer = Convert.ToInt32(Console.ReadLine());
                        int inner, l;
                        int[][] Task6Array = new int[outer][];
                        int[] Indexes = new int[outer];
                        int[] Result = new int[outer];

                        
                        for (i = 0; i<outer; i++)
                        {
                            do
                            {
                                Console.Write("Введіть розмір внутрішнього масиву: ");
                                inner = Convert.ToInt32(Console.ReadLine());
                            } while (inner>outer || inner < 1);
                            Task6Array[i] = new int[inner];
                            Indexes[i] = inner;
                        }

                        for (i = 0; i < outer; i++)
                        {
                            l = Indexes[i];
                            Console.WriteLine("Елементи " + (i + 1).ToString() + " підмасиву");
                            for (j = 0; j < l; j++)
                            {
                                Console.Write('\t');
                               Task6Array[i][j] = Convert.ToInt32(Console.ReadLine());
                            }                        
                        }
                        Console.WriteLine("Ступіньчатий масив: ");
                        for (i=0; i<outer; i++)
                        {
                            l = Indexes[i];                            
                            for (j = 0; j<l; j++)
                            {
                                Console.Write(Task6Array[i][j].ToString() + '\t');
                            }
                            Console.WriteLine();
                        }
                        int maxind = SearchMax(Indexes);

                        int minEl, ind = 0;
                        bool OK;

                        for (i=0; i<maxind; i++)
                        {
                            minEl = 2147483647;
                            for (j = 0; j<outer; j++)
                            {
                                OK = true;
                                try
                                {
                                    Task6Array[j][i] = Task6Array[j][i];

                                }
                                catch (IndexOutOfRangeException)
                                {
                                    OK = false;
                                }
                                if (OK)
                                {
                                    if (Task6Array[j][i] < minEl)
                                    {
                                        minEl = Task6Array[j][i];
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            Result[ind] = minEl;
                            ind++;
                        }
                        Console.WriteLine("Мінімальні елементи: ");
                        for (i = 0; i<ind; i++)
                        {
                            Console.Write(Result[i].ToString() + " | ");
                        }
                        Console.WriteLine();
                        break;
                    //►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►►
                    default:
                        repit = false;
                        break;                       
                }
                Console.WriteLine("________________________________________END______________________________________________\n");
            }
        }


        static int OverDiagonal(int[,] arr, int size)
        {
            int i, j, sumOfElements = 0;
            for (i = 0; i < size-1; i++)
            {
                for (j = i+1; j < size; j++)
                {
                    sumOfElements += Math.Abs(arr[i,j]);
                }
            }
            return sumOfElements;
        }


        static int UnderDiagonal(int[,] arr, int size)
        {
            int i, j, sumOfElements = 0;

            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    sumOfElements += Math.Abs(arr[j, i]);
                }
            }
            return sumOfElements;
        }




        static int[] Set_1d_array(int size, bool IsRand)
        {
            int i;
            int[] arr = new int[size];
            if (IsRand)
            {
                Random rnd = new Random();
                for (i = 0; i < size; i++)
                {
                    arr[i] = rnd.Next(-3, 10);
                }
                return arr;
            }
            else
            {
                Console.WriteLine("Введіть елементи масиву ");
                for (i = 0; i < size; i++)
                {
                    Console.Write("\t");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                return arr;
            }
        }


        static int[,] Set_2d_array(int mainSize, int subSize, bool IsRand)
        {
            int i, j;
            int[,] arr = new int[mainSize, subSize];
            int low, high;

            if (IsRand)
            {
                Console.Write("Введіть нижню межу ");
                low = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введіть верхню межу ");
                high = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                for (i = 0; i < mainSize; i++)
                {
                    for (j = 0; j < subSize; j++)
                    {
                        arr[i, j] = rnd.Next(low, high);
                    }
                }
            }
            else
            {
                Console.WriteLine("Введіть елементи масиву ");
                for (i = 0; i < mainSize; i++)
                {
                    for (j = 0; j < subSize; j++)
                    {
                        Console.Write("\t");
                        arr[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            return arr;
        }

        static void print_1d(int[] arr)
        {
            
            foreach (int el in arr)
            {
                Console.Write(el.ToString() + " | ");
            }
            Console.WriteLine();
        }


        static void print_2d(int[,] arr, int mainSize, int subSize)
        {
            int i, j;
            for (i = 0; i < mainSize; i++)
            {
                for (j = 0; j < subSize; j++)
                {
                    Console.Write(arr[i, j].ToString() + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        static int SearchMax(int[]arr)
        {
            int  MinValue = -2147483648;

            foreach (int el in arr)
            {
                if (el >= MinValue)
                {
                    MinValue = el;
                }
            }
            return MinValue;
        }
    }
}
