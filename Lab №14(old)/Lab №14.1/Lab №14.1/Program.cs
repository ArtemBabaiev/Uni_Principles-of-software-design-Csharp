using System;
using System.Collections.Generic;
using System.IO;

namespace Lab__14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string repit;
            do
            {
                Console.Write("1 - однозв'язний; 2 - двозв'язний\nВиберіть режим роботи: ");
                int type = Convert.ToInt32(Console.ReadLine());
                switch (type)
                {
                    case 1:
                        
                        
                        break;
                    case 2:
                        File.WriteAllText("Linked2.txt","");
                        LinkedList<string> Goods = new LinkedList<string>();
                        int len = 0;
                        bool repitWith2 = true;
                        while (repitWith2)
                        {
                            switch (Menu())
                            {
                                case 1.0:
                                    Goods.Clear();
                                    Goods.AddFirst("book");
                                    Goods.AddLast("pencil");
                                    Goods.AddLast("pen");
                                    Goods.AddLast("ruller");
                                    Goods.AddLast("notebook");
                                    Goods.AddLast("pencilbox");
                                    len = Goods.Count;
                                    break;
                                case 2.0:
                                    foreach (var item in Goods)
                                    {
                                        Console.Write($"{item} | ");
                                    }
                                    Console.WriteLine();
                                    break;
                                case 3.0:
                                    Console.WriteLine($"Кількість елементів {Goods.Count}");
                                    break;
                                case 4.0:
                                    if (Goods.Count == 0)
                                    {
                                        Console.WriteLine("Ліст порожній");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ліст не порожній");
                                    }
                                    break;
                                case 5.1:
                                    Console.Write("Введіть елемент: ");
                                    Goods.AddFirst(Console.ReadLine());
                                    break;
                                case 5.2:
                                    Console.Write("Введіть елемент: ");
                                    Goods.AddLast(Console.ReadLine());
                                    break;
                                case 5.3:
                                    Console.Write("Введіть індекс для вставки: ");
                                    int indexToIns = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Що вставити: ");
                                    string val = Console.ReadLine();
                                    len = Goods.Count;
                                    if (indexToIns==0)
                                    {
                                        Goods.AddFirst(val);
                                    }
                                    else if (indexToIns>=len)
                                    {
                                        Goods.AddLast(val);
                                    }
                                    else
                                    {
                                        i = 0;
                                        foreach (var item in Goods)
                                        {
                                            i++;
                                            if (i == indexToIns)
                                            {
                                                
                                                Goods.AddAfter(Goods.Find(item), val);
                                                
                                                break;
                                            }
                                        }
                                    }
                                    

                                    break;
                                case 6.1:
                                    Goods.Clear();
                                    Console.WriteLine("Ліст очищено");
                                    break;
                                case 6.2:
                                    Console.Write("Введіть індекс елементу для видалення: ");
                                    int index = Convert.ToInt32(Console.ReadLine());
                                    i = 0;
                                    foreach (var item in Goods)
                                    {
                                        if (i==index)
                                        {
                                            Goods.Remove(item);
                                            break;
                                        }
                                        i++;
                                    }
                                    break;
                                case 6.3:
                                    Console.Write("Введіть елемент для видалення: ");
                                    Goods.Remove(Console.ReadLine());
                                    break;
                                case 7.0:
                                    len = Goods.Count;
                                    Console.WriteLine("Введіть нові елементи");
                                    for (i = 0; i < len; i++)
                                    {
                                        Goods.RemoveFirst();
                                        Goods.AddLast(Console.ReadLine());
                                    }
                                    break;
                                case 8.0:
                                    Console.Write("Ведіть слово для заміни: ");
                                    string str = Console.ReadLine();
                                    len = Goods.Count;
                                    for (i = 0; i < len; i++)
                                    {
                                        Goods.RemoveFirst();
                                        Goods.AddLast(str);
                                    }
                                    break;
                                case 9.0:
                                    len = Goods.Count;
                                    Console.Write("Ведіть слово для пошуку: ");
                                    string toSearch = Console.ReadLine();
                                    if (Goods.Contains(toSearch))
                                    {
                                        int l = 0;
                                        foreach (var item in Goods)
                                        {
                                            if (item==toSearch)
                                            {
                                                break;
                                            }
                                            l++;
                                        }
                                        Console.WriteLine($"Елемент наявний у списку, його індекс {l}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Елемент не знайдено");
                                    }
                                    break;
                                case 10.0:
                                    string[] arr = new string[Goods.Count];
                                    i = 0;
                                    foreach (var item in Goods)
                                    {
                                        arr[i] = item;
                                        i++;
                                    }
                                    Array.Sort(arr);
                                    foreach (var item in arr)
                                    {
                                        Goods.RemoveFirst();
                                        Goods.AddLast(item);
                                    }
                                    break;
                                case 11.0:
                                    len = Goods.Count;
                                    i = 0;
                                    foreach (var item in Goods)
                                    {
                                        File.AppendAllText("Linked2.txt", item + "\n");
                                    }
                                    break;
                                case 12.0:
                                    string[] fromFile = File.ReadAllLines("Linked2.txt");
                                    Goods.Clear();
                                    foreach (var item in fromFile)
                                    {
                                        Goods.AddLast(item);
                                    }
                                    break;
                                default:
                                    repitWith2 = false;
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
                List<int> a = new List<int>();
                
                Console.WriteLine("Введіть N для закінчення: ");
                repit = Console.ReadLine();
            } while (repit!="N");
            
        }
        static double Menu()
        {
            Console.WriteLine("1)	формування списку\n2)	перегляд елементів списку\n3)	визначення кількості елементів списку\n4)	перевірка списку на відсутність елементів");
            Console.WriteLine("5)	вставка елементів в список\n6)	видалення елементів із списку\n7)	редагування елементів списку\n8)	заміна всіх елементів списку");
            Console.WriteLine("9)	пошук елементів в списку за заданим полем\n10)	сортування елементів списку\n11)	збереження списку у файл\n12)	завантаження списку із файлу");
            Console.WriteLine("Оберіть операцію: ");
            double op = Convert.ToDouble(Console.ReadLine());
            if (op == 5)
            {
                Console.WriteLine("1)	на початок\n2)	в кінець\n3)	у відповідну позицію");
                Console.Write("Оберіть опцію: ");
                op+=Convert.ToDouble(Console.ReadLine())/10;
            }
            if (op == 6)
            {
                Console.WriteLine("1)	всіх елементів\n2)	конкретного елементу\n3)	елементу із заданим значенням\n");
                Console.Write("Оберіть опцію: ");
                op += Convert.ToDouble(Console.ReadLine()) / 10.0;
            }
            return op;
        }
    }
}
