using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12._3
{
    abstract class Animal
    {
        protected string name;
        protected string breed;
        protected bool wasInVet;
        protected DateTime date = new DateTime();
        public Animal()
        {
            this.name = "default";
            this.breed = "default";
            this.wasInVet = false;
        }
        public Animal(string name, string breed, bool wasInVet)
        {
            Random rnd = new Random();
            this.name = name;
            this.breed = breed;
            this.wasInVet = wasInVet;
            if (wasInVet)
            {
                date = new DateTime(rnd.Next(2000, 2021), rnd.Next(1, 12), rnd.Next(1, 31));
            }
        }

        public abstract void Command(string command);

        public abstract void Call(string call);
        
        public string DateOfVet
        {
            get => wasInVet ? date.ToString("d") : "Ніколи не була";
        }
        public virtual void Show()
        {
            Console.Write($"Name: {name} | Breed: {breed} | DateOfVet: {DateOfVet} | ");
        }
        
    }
}
