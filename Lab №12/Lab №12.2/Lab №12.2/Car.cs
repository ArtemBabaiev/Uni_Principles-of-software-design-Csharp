using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._2
{
    class Car
    {
        protected string name;
        protected int maxSpeed;
        protected string color;

        public Car()
        {
            this.name = "default";
            this.maxSpeed = -1;
            this.color = "default";
        }
        public Car(string name, int maxSpeed, string color)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.color = color;
        }
        
        public virtual int Cost()
        {
            return maxSpeed * 100;
        }
        public virtual void UpdateModel()
        {
            maxSpeed += 10;
        }
        public virtual void Information()
        {
            Console.WriteLine($"Назва: { name} | Максимальна швидкість: { maxSpeed} | Колір: { color} | Вартість: {Cost()}");
        }
    }
}
