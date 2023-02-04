using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._1
{
    class Teacher:Person
    {
        protected string disciplines;
        protected int salary;
        protected int experience;

        public Teacher()
        {
            this.disciplines = "Default";
            this.salary = -1;
            this.experience = -1;
        }
        public Teacher(string disciplines, int salary, int experience):base()
        {
            this.disciplines = disciplines;
            this.salary = salary;
            this.experience = experience;
        }
        public Teacher(string disciplines, int salary, int experience, string name, string sex, int age) : base(name, sex, age)
        {
            this.disciplines = disciplines;
            this.salary = salary;
            this.experience = experience;
        }
        ~Teacher()
        {
            Console.WriteLine("Викладча видалено");
        }
        public override void Show()
        {
            Console.WriteLine($"Ім'я: {name} | Стать: {sex} | Вік: {age}");
            Console.WriteLine($"Дисципліни: {disciplines} | Стаж: {experience} | Зарплатня: {salary}");
        }
        public override void Activity()
        {
            Console.WriteLine("Викладає");
        }
    }
}
