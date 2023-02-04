using System;

namespace Lab__11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(1, 2, "red");
            point[0] = 5;
            Console.WriteLine(point[0]);
            point.PrintCoord();
            var convertedPoint = Point.ToPoint("5 4 red");
            convertedPoint.PrintCoord();
            Console.WriteLine(convertedPoint.Color);
        }
    }
}
