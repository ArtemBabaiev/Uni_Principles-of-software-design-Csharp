using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._4
{
    class Docent:ITeacher
    {
        protected string name;
        protected string subject;

        public Docent(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }
        public Proffesor Upgrade()
        {
            return new Proffesor(name, subject, "math");
            
        }
        public void Introduce()
        {
            Console.WriteLine($"Мене звати {name},  буду викладати предмет під назвою {subject}");
        }
        public int PutMark()
        {

            return (new Random()).Next(1, 6);
        }
    }
}
