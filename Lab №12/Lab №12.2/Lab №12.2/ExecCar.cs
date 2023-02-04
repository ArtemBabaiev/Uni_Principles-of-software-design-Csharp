using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._2
{
    class ExecCar:Car
    {
        protected bool isCond;

        public ExecCar()
        {
            this.isCond = false;
        }
        public ExecCar(bool isCond):base()
        {
            this.isCond = isCond;
        }
        public ExecCar(bool isCond, string name, int maxSpeed, string color) : base(name, maxSpeed, color)
        {
            this.isCond = isCond;
        }
        public override int Cost()
        {
            return maxSpeed * 250;
        }
        public override void UpdateModel()
        {
            maxSpeed += 50;
        }
        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Наявність кондиціонеру: {isCond}");
        }
    }
}
