using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._1
{
    class Person
    {
        protected string name;
        protected string sex;
        protected int age;

        public Person()
        {
            this.name = "Default name";
            this.sex = "Default sex";
            this.age = -1;
        }

        public Person(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        ~Person()
        {
            Console.WriteLine("Персону видалено");
        }

        public virtual void Show()
        {
            Console.WriteLine($"Ім'я: {name} | Стать: {sex} | Вік: {age}");
        }
        public virtual void Activity()
        {
            Console.WriteLine("прокинутися, поїсти, піти на роботу, попрацювати, прийти додому, поїсти, спати");
        }
    }
}
