using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace Lab__13._1
{
    class Program
    {
        delegate void SortDel(Student[] a);
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Кількість елементів масиву: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] Stud = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ім'я: ");
                string tempstr = Console.ReadLine();
                Console.Write("Група: ");
                int tempint = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть бали");
                int[] temparr = new int[5] { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };
                Stud[i] = new Student(tempstr, tempint, temparr);
            }
            Console.WriteLine("Сортований масив");
            Array.Sort(Stud);
            for (int i = 0; i < Stud.Length; i++)
            {
                Stud[i].Show2();
            }
            int j = 0;
            Console.WriteLine("Більше за 4,0");
            for (int i = 0; i < n; i++)
            {
                if (Stud[i].GetAverage > 4)
                {
                    j++;
                    Stud[i].Show1();
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Студентів не знайдено");
            }

            Console.WriteLine("\n*****************************Додаткові завдання*****************************\n");
            Console.WriteLine("Додаткове № 1");

            File.WriteAllText("Students.txt", "");

            int repit;
            do
            {
                Console.Write("Ввeдіть у файл(0 - для продовження): ");
                repit = Convert.ToInt32(Console.ReadLine());
            } while (repit != 0);
            string[] text = File.ReadAllLines("Students.txt");
            Student[] fromFile = new Student[text.Length];
            int l = 0;
            foreach (var item in text)
            {
                string[] temp = Regex.Split(item, @"\|");
                string[] TSTRGrades = Regex.Split(temp[2], @" ");
                int[] TGrades = new int[TSTRGrades.Length];
                for (int i = 0; i < TSTRGrades.Length; i++)
                {
                    TGrades[i] = Convert.ToInt32(TSTRGrades[i]);
                }
                
                    fromFile[l] = new Student(temp[0], Convert.ToInt32(temp[1]), TGrades);
                l++;
            }
            foreach (var item in fromFile)
            {
                item.Show2();
            }
            File.WriteAllText("Students.txt", "");
            string[] StrTemp = new string[Stud.Length];
            for (int i = 0; i < StrTemp.Length; i++)
            {
                StrTemp[i] = Stud[i].ToString();
            }
            File.WriteAllLines("Students.txt", StrTemp);
            Console.WriteLine("Додаткове № 2");
            SortDel srt = Sort1;
            Console.WriteLine("За чим сортувати");
            Console.Write("1 - ім'я, 2 - група, 3 - Сер.бал: ");
            int byWhat = Convert.ToInt32(Console.ReadLine());
            switch (byWhat)
            {
                case 1:
                    srt = Sort1;
                    break;
                case 2:
                    srt = Sort2;
                    break;
                case 3:
                    srt = Sort3;
                    break;
                default:
                    break;
            }
            srt(fromFile);

            Console.WriteLine("Сортований масив");
            for (int i = 0; i < fromFile.Length; i++)
            {
                fromFile[i].Show2();
            }
            Console.WriteLine("Додаткове № 3");

            using (BinaryWriter writer = new BinaryWriter(File.Open("Student.dat", FileMode.Open)))
            {
                foreach (var item in Stud)
                {
                    writer.Write(item.Group);
                    foreach (var el in item.Ses)
                    {
                        writer.Write(el);
                    }
                }
            }


            do
            {
                Console.Write("Номер студента: ");
                int numOfStudent = Convert.ToInt32(Console.ReadLine());
                if (numOfStudent<1 && numOfStudent>Stud.Length)
                {
                    break;
                }
                Console.Write("Що замінити:\n 1 - групу; 2 - оцінки; 3 - оцінки і групу\n");
                int whatToChange = Convert.ToInt32(Console.ReadLine());
                switch (whatToChange)
                {
                    case 1:
                        ChangeGroup(numOfStudent);
                        break;
                    case 2:
                        ChangeMarks(numOfStudent);
                        break;
                    case 3:
                        ChangeBoth(numOfStudent);
                        break;
                    default:
                        break;
                }
                Console.Write("Повторити заміну(0 - ні): ");
                repit = Convert.ToInt32(Console.ReadLine());
            } while (repit != 0);

            ReplaceValues(Stud);
            Console.WriteLine("Оновлений масив");
            for (int i = 0; i < Stud.Length; i++)
            {
                Stud[i].Show2();
            }
        }

        static void ChangeGroup(int num)
        {
            num--;
            int start = 0 + num * 24;
            using (Stream stream = File.Open("Student.dat", FileMode.Open))
            {
                stream.Position = start;
                Console.Write("Новий номер групи: ");
                var temp = BitConverter.GetBytes(Convert.ToInt32(Console.ReadLine()));
                stream.Write(temp, 0, temp.Length);
            }
        }
        static void ChangeMarks(int num)
        {
            num--;
            int start = 4 + num * 24;
            using (Stream stream = File.Open("Student.dat", FileMode.Open))
            {
                stream.Position = start;
                Console.Write("Введіть оцінки:\n");
                for (int i = 0; i < 5; i++)
                {
                    var temp = BitConverter.GetBytes(Convert.ToInt32(Console.ReadLine()));
                    stream.Write(temp, 0, temp.Length);
                }
                
            }
        }
        static void ChangeBoth(int num)
        {
            num--;
            int start = 0 + num * 24;
            using (Stream stream = File.Open("Student.dat", FileMode.Open))
            {
                stream.Position = start;
                Console.Write("Новий номер групи: ");
                var temp = BitConverter.GetBytes(Convert.ToInt32(Console.ReadLine()));
                stream.Write(temp, 0, temp.Length);

                Console.Write("Введіть оцінки:\n");
                for (int i = 0; i < 5; i++)
                {
                    var tempA = BitConverter.GetBytes(Convert.ToInt32(Console.ReadLine()));
                    stream.Write(tempA, 0, tempA.Length);
                }
            }
        }
        
        static void ReplaceValues(Student[] arr)
        {
            using (BinaryReader reader = new BinaryReader(File.Open("Student.dat", FileMode.Open)))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i].Group = reader.ReadInt32();
                    for (int j = 0; j < arr[i].Ses.Length; j++)
                    {
                        arr[i].Ses[j] = reader.ReadInt32();
                    }
                }

            }
        }
        
        static void Sort1(Student[] arr)
        {
            Array.Sort(arr, new ComparatorByName());
        }
        static void Sort2(Student[] arr)
        {
            Array.Sort(arr);

        }
        static void Sort3(Student[] arr)
        {
            Array.Sort(arr, new ComparatorByMark());
        }

    }
}

/*BinaryFormatter formatter = new BinaryFormatter();
using (FileStream fs = new FileStream("Student.dat", FileMode.OpenOrCreate))
{
    // сериализуем весь массив people
    formatter.Serialize(fs, Stud);
    
}*/