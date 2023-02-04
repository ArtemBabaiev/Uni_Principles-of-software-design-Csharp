using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab__7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool repit = true;
            int length = 100, k;
            int[] A = new int[length];
            int[] B = new int[length];
            A = SetArray(length);
            B = SetArray(length);
            Array.Sort(A);
            Array.Sort(B);
            Console.WriteLine("Масив А");
            PrintArray(A, length);
            Console.WriteLine("Масив В");
            PrintArray(B, length);
            while (repit)
            {
                Console.Write("Введіть номер пошуку: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int[] CommonItems = new int[length];
                switch (num)
                {
                    case 1:
                        k = 0;
                        foreach (int element in A)
                        {
                            string strItem = BinarySearch(B, element);
                            bool insertion = true;
                            if (strItem == null)
                            {
                                continue;
                            }
                            else
                            {
                                int item = Convert.ToInt32(strItem);
                                for (int j = 0; j < k; j++)
                                {
                                    if (item == CommonItems[j])
                                    {
                                        insertion = false;
                                    }
                                }
                                if (insertion == true)
                                {
                                    CommonItems[k] = item;
                                    k++;
                                }
                            }
                        }
                        Console.WriteLine("Однакові елементи:");
                        PrintArray(CommonItems, k);
                        break;
                    case 2:
                        k = 0;
                        foreach (int element in A)
                        {
                            string strItem = BinarySearch(B, element);
                            bool insertion = true;
                            if(strItem == null)
                            {
                                continue;
                            }
                            else
                            {
                                int item = Convert.ToInt32(strItem);
                                for (int j = 0; j < k; j++)
                                {
                                    if(item == CommonItems[j])
                                    {
                                        insertion = false;
                                    }
                                }
                                if (insertion==true)
                                {
                                    CommonItems[k] = item;
                                    k++;
                                }
                            }
                        }
                        Console.WriteLine("Однакові елементи:");
                        PrintArray(CommonItems, k);
                        break;
                    case 3:
                        //SubarrSearch(A, B);
                        string strA = "revolutioner";
                        string strB = "conditioner";
                        Console.WriteLine(strA);
                        Console.WriteLine(strB);
                        SubstringSearch(strA, strB);
                        break;
                    default:
                        repit = false;
                        break;
                }
            }
        }

        static string LinearSearch(int[] arr, int el)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == el)
                {
                    return el.ToString();
                }
            }
            return null;
        }

        static string BinarySearch(int[] arr, int el)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int midIndex = start + Convert.ToInt32((end - start) / 2);
                int midElement = arr[midIndex];
                if (midElement == el)
                {
                    return midElement.ToString();
                }
                else if (el<midElement)
                {
                    end = midIndex - 1;
                }
                else
                {
                    start = midIndex + 1;
                }
            }
            return null;
        }

        static void SubstringSearch(string S, string T)
        {
            int sizeS = S.Length;
            int sizeT = T.Length;
            int[,] Table = new int[sizeS + 1, sizeT + 1];
            string substring = "";
            for (int i = 0; i < sizeS+1; i++)
            {
                for (int j = 0; j < sizeT+1; j++)
                {
                    Table[i, j] = 0;
                }
            }
            int longest = 0;
            HashSet<string> common_substring = new HashSet<string>() {"Немає спільного"};

            for (int i = 0; i < sizeS; i++)
            {
                for (int j = 0; j <sizeT; j++)
                {
                    if(S[i] == T[j])
                    {
                        int c = Table[i, j] + 1;
                        Table[i + 1, j + 1] = c;
                        if (c > longest)
                        {
                            common_substring.Clear();
                            substring = SetSubstring(i - c + 1, i + 1, S);
                            common_substring.Add(substring);
                        }
                        else if (c == longest)
                        {
                            substring = SetSubstring(i - c + 1, i + 1, S);
                            common_substring.Add(substring);
                        }
                    }
                }
            }
            foreach(var el in common_substring) 
            {
                Console.WriteLine(el);
            }
        }





        static void SubarrSearch(int[] FromArr, int[] InArray)
        {
            int i, step, j;
            int maxLen = 0;
            string Result = "Нема";
            for(i = 0; i < FromArr.Length; i++)
            {
                for(step = 0; step < FromArr.Length + 1-i; step++)
                {
                    int[] SubarrayA = SetSubarray(i, i + step, FromArr);
                    for(j = 0; j < InArray.Length; j++)
                    {
                        int[] SubarrayB = SetSubarray(j, j + step, InArray);
                        /*PrintArray(SubarrayA, SubarrayA.Length);
                        Console.Write(" //  ");
                        PrintArray(SubarrayB, SubarrayB.Length);
                        Console.WriteLine();*/
                        if (SubarrayA.SequenceEqual(SubarrayB) && SubarrayA.Length >= maxLen)
                        {
                            if(SubarrayA.Length > maxLen)
                            {
                                maxLen = SubarrayA.Length;
                                Result = string.Join(" | ", SubarrayA);
                            }
                            else if(SubarrayA.Length == maxLen)
                            {
                                Result = Result + "\n" + string.Join(" | ", SubarrayA);
                            } 
                            
                            
                        }
                    }
                }
            }
            Console.WriteLine("Найбільші підрядки");
            Console.WriteLine(Result);
        }
        static int[] SetSubarray(int start, int end, int[] Source)
        {
            int i;
            int j = 0;
            int[] arr = new int[end - start];
            for(i = start; i < end && i<Source.Length; i++)
            {
                arr[j] = Source[i];
                j++;
            }
            return arr;
        }
        static string SetSubstring(int start, int end, string Source)
        {
            int i;
            int j = 0;
            string substr = "";
            for (i = start; i < end && i < Source.Length; i++)
            {
                substr = substr + Source[i];
                j++;
            }
            return substr;
        }
        static int[] SetArray(int size)
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
        static void PrintArray(int[] arr, int size)
        {

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i].ToString() + " | ");
                if(i == 19 || i== 39 || i== 59 || i== 79)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
