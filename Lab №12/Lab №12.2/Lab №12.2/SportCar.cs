using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._2
{
    class SportCar:Car
    {
        protected int numOfSeats;
        public SportCar()
        {
            this.numOfSeats = -1;
        }
        public SportCar(int numOfSeats):base()
        {
            this.numOfSeats = numOfSeats;
        }
        public SportCar(int numOfSeats, string name, int maxSpeed, string color):base(name, maxSpeed, color)
        {
            this.numOfSeats = numOfSeats;
        }
        public override int Cost()
        {
            return maxSpeed * 350;
        }
        public override void UpdateModel()
        {
            maxSpeed += 100;
        }
        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Кіль-сть місць: {numOfSeats}");
        }

    }
}
