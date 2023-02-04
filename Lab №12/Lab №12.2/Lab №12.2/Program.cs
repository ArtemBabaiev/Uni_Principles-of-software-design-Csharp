using System;

namespace Lab__12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var car = new Car();
            Console.WriteLine("*******************************CAR*******************************");
            car.Information();
            var sport = new SportCar( 4, "a", 300, "black");
            Console.WriteLine("*******************************SPORT CAR*******************************");
            sport.Information();
            var exec = new ExecCar(true, "BMW", 240, "black");
            Console.WriteLine("*******************************EXEC CAR*******************************");
            exec.Information();
            car.UpdateModel();
            exec.UpdateModel();
            sport.UpdateModel();
            Console.WriteLine("*******************************CAR*******************************");
            car.Information();
            Console.WriteLine("*******************************SPORT CAR*******************************");
            sport.Information();
            Console.WriteLine("*******************************EXEC CAR*******************************");
            exec.Information();

        }
    }
}
