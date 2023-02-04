using System;

namespace Lab__13._1
{
    [Serializable]
    public struct Student : IComparable<Student>
    {
        [NonSerialized]
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
                if (i<4)
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
            if (this.Group>other.Group)
            {
                return 1;
            }
            else if (this.Group<other.Group)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name}|{group}|{Ses[0]} {Ses[1]} {Ses[2]} {Ses[3]} {Ses[4]}";
        }
        public override bool Equals(object obj)
        {
            Student temp = (Student)obj;
            if (this.Name == temp.Name && this.Group == temp.Group)
            {
                return true;
            }
            else
            {
                return false;
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