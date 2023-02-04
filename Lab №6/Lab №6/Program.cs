using System;

namespace Lab__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int length = 100;
            int[] A = new int[length];
            int[] B = new int[length];
            int[] copy = new int[length];
            A = Set_1d_array(length);
            B = Set_1d_array(length);
            Console.WriteLine("Масив А:");
            print_1d(A);
            Console.WriteLine();
            Console.WriteLine("Масив B:");
            print_1d(B);
            Console.WriteLine();

            bool repit = true;
            int num;
            while (repit)
            {
                Console.WriteLine("1 -Бульбашка, 2 - Шейкерне, 3 - Вставками, 4 - Частинами");
                Console.WriteLine("5 - Шелл, 6 - Злиття, 7 - Вибором, 8 - Гоара");
                Console.Write("Введіть номер методу сортування: ");
                num = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("___________________________________Start__________________________________\n");
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Сортування бульбашкою ");
                        copy = A;
                        BubbleSort(A, length);
                        print_1d(A);
                        A = copy;
                        break;
                    case 2:
                        Console.WriteLine("Шейкерне сортування");
                        copy = A;
                        ShakerSort(A, length);
                        print_1d(A);
                        A = copy;
                        break;
                    case 3:
                        Console.WriteLine("Сортування вставками");
                        copy = A;
                        InserionSort(A, length);
                        print_1d(A);
                        A = copy;
                        break;
                    case 4:
                        Console.WriteLine("Сортування частинами");
                        copy = A;
                        StoogeSort(A, 0, length - 1);
                        print_1d(A);
                        A = copy;
                        break;
                    case 5:
                        Console.WriteLine("Сортування Шелла ");
                        copy = B;
                        ShellSort(B, length);
                        print_1d(B);
                        B = copy;
                        break;
                    case 6:
                        Console.WriteLine("Сортування злиттям ");
                        copy = B;
                        MergeSort(B, 0, length-1);
                        print_1d(B);
                        B = copy;
                        break;
                    case 7:
                        Console.WriteLine("Сортування вибором ");
                        copy = B;
                        SelectionSort(B, length);
                        print_1d(B);
                        B = copy;
                        break;
                    case 8:
                        Console.WriteLine("Cортування Гоара ");
                        copy = B;
                        QuickSort(B, 0, length - 1);
                        print_1d(B);
                        B = copy;
                        break;
                    default:
                        repit = false;
                        break;
                }
                Console.WriteLine("___________________________________End__________________________________\n");
            }
        }

        static void BubbleSort(int[] arr, int size)                         // 1
        {
            int i, j, temp;
            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < size - i - 1; j++)  //-i, щоб не брати остнанній елемент, які відсортовано. -1 для межі
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void ShakerSort(int[] arr, int size)                         // 2
        {
            int lstart = 0;
            int rstart = size - 1;
            int temp;
            while (lstart < rstart)
            {
                for (int i = lstart; i < rstart; i++)       //Ідемо від початку до кінця
                {
                    if(arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                rstart--;
                for (int i = rstart; i > lstart; i--)       //Ідемо від кінця до початку
                {
                    if(arr[i] < arr[i-1]) 
                    {
                        temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                }
                lstart++;
            }
        }
        static void InserionSort(int[] arr, int size)                       // 3
        {
            int temp;
            for (int i = 1; i < size; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        static void StoogeSort(int[] arr, int startIndex, int endIndex)     // 4
        {
            if (arr[startIndex] > arr[endIndex])
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
            }
            if (endIndex - startIndex > 1)
            {
                var len = (endIndex - startIndex + 1) / 3;
                StoogeSort(arr, startIndex, endIndex - len);
                StoogeSort(arr, startIndex + len, endIndex);
                StoogeSort(arr, startIndex, endIndex - len);
            }
        }
        static void ShellSort(int[] arr, int size)                          // 5
        {
            int step = size, temp, i, j;
            while (step > 1)        //поки крок більше 1
            {
                step /= 2;          //крок 1 враховується
                for (i = step; i < size; i++)
                {
                    for (j = i; j >= step; j -= step)
                    {
                        if (arr[j - step] > arr[j])
                        {
                            temp = arr[j - step];
                            arr[j - step] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
        }
        static void MergeSort(int[] arr, int leftEdge, int rightEdge)       // 6
        {
            if (leftEdge < rightEdge)
            {
                int midEdge = leftEdge + (rightEdge - leftEdge) / 2;
                MergeSort(arr, leftEdge, midEdge);              //рекурсією повторюємо доки не буде мінімальний масив, потім працюємо з правою частиною
                MergeSort(arr, midEdge + 1, rightEdge);

                int leftSize = midEdge - leftEdge + 1;          //Після знаходження мін масивів, знаходимо їх розміри
                int rightSize = rightEdge - midEdge;

                int[] LeftArray = new int[leftSize];
                int[] RightArray = new int[rightSize];
                int i, j;

                for (i = 0; i < leftSize; ++i)              //копіюємо дані з даного масиву
                    LeftArray[i] = arr[leftEdge + i];
                for (j = 0; j < rightSize; ++j)
                    RightArray[j] = arr[midEdge + 1 + j];

                i = 0;      //індекси для лівого та правого масиву
                j = 0;
                int k = leftEdge; //індекс для перезапису

                while (i < leftSize && j < rightSize)
                {
                    if (LeftArray[i] <= RightArray[j])
                    {
                        arr[k] = LeftArray[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = RightArray[j];
                        j++;
                    }
                    k++;
                }
                while (i < leftSize)        //копіюємо те що залишиться в масивах
                {
                    arr[k] = LeftArray[i];
                    i++;
                    k++;
                }

                while (j < rightSize)
                {
                    arr[k] = RightArray[j];
                    j++;
                    k++;
                }
            }
        }
        static void SelectionSort(int[] arr, int size)                      // 7
        {
            int smallestElementIndex, temp;
            for (int i = 0; i < size-1; i++)
            {
                smallestElementIndex = i;
                for (int j = i+1; j < size; j++)
                {
                    if(arr[j] < arr[smallestElementIndex])
                    {
                        smallestElementIndex = j;
                    }
                }
                temp = arr[smallestElementIndex];
                arr[smallestElementIndex] = arr[i];
                arr[i] = temp;
            }
        }
        static void QuickSort(int[] arr, int start, int end)                // 8
        {
            if (start < end)
            {
                int divIndex = ForQuick(arr, start, end);           //знаходження індексу опорного значення
                QuickSort(arr, start, divIndex - 1);                //Опорне значення на своєму місці
                QuickSort(arr, divIndex+1, end);
            }
        }
        static int ForQuick(int[] arr, int start, int pivotIndex)
        {
            int pivot = arr[pivotIndex];        //опорний останній
            int endOfSmaller = (start - 1);
            int temp;

            for (int i = start; i <= pivotIndex - 1; i++)       //ідемо по всіх елементах крім опорного
            {
                if (arr[i] < pivot)
                {
                    endOfSmaller++;                             //збільшуємо кінцевий індекс менших та міняємо поточне значення з елементом
                    temp = arr[endOfSmaller];
                    arr[endOfSmaller] = arr[i];
                    arr[i] = temp;
                }
            }
            temp = arr[endOfSmaller + 1];               //вставляємо опорний між менших та більших
            arr[endOfSmaller + 1] = arr[pivotIndex];
            arr[pivotIndex] = temp;
            return (endOfSmaller + 1);
        }


        static int[] Set_1d_array(int size)
        {
            int i;
            int[] arr = new int[size];
            Random rnd = new Random();
            for (i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(-49, 50);
            }
            return arr;
        }
        static void print_1d(int[] arr)
        {
            int i = 1;
            foreach (int elem in arr)
            {
                Console.Write(elem.ToString() + " | ");
                if(i == 20 || i==40 || i == 60 || i==80)
                {
                    Console.WriteLine();
                }
                i++;
            }
            Console.WriteLine();
        }

    }
}
