using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._4
{
    class Proffesor:ITeacher
    {
        protected string name;
        protected string subject;
        protected string subjectPHD;

        public Proffesor(string name, string subject, string subjectPHD)
        {
            this.name = name;
            this.subject = subject;
            this.subjectPHD = subjectPHD;
        }

        public void PHD()
        {
            Console.WriteLine($"Доктор {subjectPHD} наук");
        }
        public void Introduce()
        {
            Console.WriteLine($"Мене звати {name}, буду викладати предмет під назвою {subject}");
        }
        public int PutMark()
        {
            return (new Random()).Next(1, 6);
        }
    }
}
