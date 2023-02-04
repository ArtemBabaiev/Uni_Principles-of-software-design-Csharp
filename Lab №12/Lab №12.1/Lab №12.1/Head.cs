using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._1
{
    class Head : Person
    {
        protected string cathedra;
        protected int yearsAsHead;
        protected int salary;

        public Head()
        {
            this.cathedra = "default";
            this.yearsAsHead = -1;
            this.salary = -1;
        }

        public Head(string cafedra, int yearsAsHead, int salary) :base()
        {
            this.cathedra = cafedra;
            this.yearsAsHead = yearsAsHead;
            this.salary = salary;
        }
        public Head(string cafedra, int yearsAsHead, int salary, string name, string sex, int age) : base(name, sex, age)
        {
            this.cathedra = cafedra;
            this.yearsAsHead = yearsAsHead;
            this.salary = salary;
        }

        ~Head()
        {
            Console.WriteLine("Зав.кафедри видалено");
        }
        public override void Show()
        {
            Console.WriteLine($"Ім'я: {name} | Стать: {sex} | Вік: {age}");
            Console.WriteLine($"Кафедра: {cathedra} | Років на посаді: {yearsAsHead} | Зарплата: {salary}");
        }

        public override void Activity()
        {
            Console.WriteLine("Завідує");

        }
    }
}
