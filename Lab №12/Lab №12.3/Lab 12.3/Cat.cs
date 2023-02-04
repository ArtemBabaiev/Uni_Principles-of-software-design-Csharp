using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12._3
{
    class Cat: Animal
    {
        protected int mass;

        public Cat():base()
        {
            this.mass = -1;
        }
        public Cat(int mass):base()
        {
            this.mass = mass;
        }
        public Cat(int mass, string name, string breed, bool wasInVet): base(name, breed, wasInVet)
        {
            this.mass = mass;
        }
        
        public void Meow()
        {
            Console.WriteLine("MEOW");
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Масса: {mass} | ");
        }
        public override void Call(string call)
        {
            if (call == name)
            {
                Console.WriteLine("*відізвався");
            }
            else
            {
                Console.WriteLine("*нічого не сталося");
            }
        }
        public override void Command(string command)
        {
            Console.WriteLine("*ігнорує");
        }
    }
}
