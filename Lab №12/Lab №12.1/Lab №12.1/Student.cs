using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._1
{
    class Student:Person
    {
        private int yearOfStudy;
        private double averageMark;
        private string formOfEducation;
        public Student() 
        {
            this.yearOfStudy = -1;
            this.averageMark = -1.0;
            this.formOfEducation = "Default";
        }
        public Student(int yearOfStudy, double averageMark, string formOfEducation):base()
        {
            this.yearOfStudy = yearOfStudy;
            this.averageMark = averageMark;
            this.formOfEducation = formOfEducation;
        }
        public Student(int yearOfStudy, double averageMark, string formOfEducation, string name, string sex,int age): base(name, sex, age)
        {
            this.yearOfStudy = yearOfStudy;
            this.averageMark = averageMark;
            this.formOfEducation = formOfEducation;
        }
        ~Student()
        {
            Console.WriteLine("Студента видалено");
        }
        public override void Show()
        {
            Console.WriteLine($"Ім'я: {name} | Стать: {sex} | Вік: {age}");
            Console.WriteLine($"Курс: {yearOfStudy} | Середній бал: {averageMark} | Форма навчання: {formOfEducation}");
        }

        public override void Activity()
        {
            Console.WriteLine("Прокинутися, піти на пару, попрацювати на парі, поїсти підчас пари, піти спати");
        }
    }
}
