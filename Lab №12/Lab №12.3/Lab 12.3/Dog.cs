using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12._3
{
    class Dog:Animal
    {
        protected bool forHunt;
        
        public Dog():base()
        {
            this.forHunt = false;
        }

        public Dog(bool forHunt):base()
        {
            this.forHunt = forHunt;
        }
        public Dog(bool forHunt, string name, string breed, bool wasInVet):base(name, breed, wasInVet)
        {
            this.forHunt = forHunt;
        }
        
        public void Bark()
        {
            Console.WriteLine("BARK");
        }
        public override void Command(string command)
        {
            Console.WriteLine($"{name} зробив команду {command}");
        }
        public override void Call(string call)
        {
            Console.WriteLine("*махає хвостом");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Придатна до полювання: {forHunt} | ");
        }
    }
}
