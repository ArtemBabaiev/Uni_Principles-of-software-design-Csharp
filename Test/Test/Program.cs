using System;
using System.IO;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var con = Convert.ToByte(12);
            Student std = new Student("art", 145, new int[]{ 1, 5, 4 , 7, 5});
            std.Show2();
            string path = "studOne.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
            {
                //writer.Write(std.Name);
                writer.Write(std.Group);
                foreach (var el in std.Ses)
                {
                    writer.Write(el);
                }
            }
            using(Stream stream = File.Open(path, FileMode.Open))
            {
                stream.Position = 0;
                var temp = BitConverter.GetBytes(1985);
                stream.Write(temp, 0, temp.Length);
                /*stream.Position = 0;
                var temp = Encoding.ASCII.GetBytes("abcd");
                stream.Write(temp, 0, temp.Length);*/
            }

            string TName;
            int TGroup;
            int[] TSes = new int[std.Ses.Length];

            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                //TName = reader.ReadString();
                TGroup = reader.ReadInt32();

                for (int i = 0; i < std.Ses.Length; i++)
                {
                    TSes[i] = reader.ReadInt32();
                }
            }

            var stud = new Student("new", TGroup, TSes);
            stud.Show2();
        }
    }
    [Serializable]
    struct Student : IComparable<Student>
    {
        string name;
        int group;
        int[] ses;

        

        public Student(string name, int group, int[] ses)
        {
            this.name = name;
            this.group = group;
            this.ses = ses;
        }

        public string Name { get => name; set => name = value; }
        public int Group { get => group; set => group = value; }
        public int[] Ses { get => ses; set => ses = value; }

        private string SesString()
        {
            string temp = "";
            for (int i = 0; i < 5; i++)
            {
                if (i < 4)
                {
                    temp += Ses[i].ToString() + ",";
                }
                else
                {
                    temp += Ses[i].ToString();
                }
            }
            return temp;
        }

        public double GetAverage
        {
            get => (ses[1] + ses[2] + ses[3] + ses[4] + ses[0]) / 5.0;
        }
        public int CompareTo(Student other)
        {
            if (this.Group > other.Group)
            {
                return 1;
            }
            else if (this.Group < other.Group)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public void Show1()
        {
            Console.WriteLine($"Ім'я: {name} | Група: {group}");
        }
        public void Show2()
        {
            Console.WriteLine($"Ім'я: {name} | Група: {group} | Сер.Бал {GetAverage}");
        }
    }
}
