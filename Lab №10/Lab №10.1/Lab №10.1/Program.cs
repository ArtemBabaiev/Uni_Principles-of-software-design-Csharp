using System;

namespace Lab__10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var point = new Point(2, 3, "red");
            var pointZero = new Point("black");
            Console.WriteLine("Початкові координати точки: ");
            point.PrintCoord();

            Console.WriteLine ("Координати точки після переміщення: ");
            point.MovePoint(4, -3);
            point.PrintCoord();

            Console.WriteLine($"Колір точки: {point.Color}");
            point.X = 5;
            Console.WriteLine($"Координатa X: {point.X}");
            
        }
    }

    public class Point
    {
        private double x;
        private double y;
        private string color;

        public Point(double x, double y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public Point(string color)
        {
            this.x = 0;
            this.y = 0;
            this.color = color;
        }

        public void PrintCoord()
        {
            Console.WriteLine($"Координати Х: {x}\nКоординати Y: {y}");
        }
        
        public double EvalLen()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public void MovePoint(double a, double b)
        {
            x += a;
            y += b;
        }

        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }
        public string Color
        {
            get => color;
        }
    }
}
