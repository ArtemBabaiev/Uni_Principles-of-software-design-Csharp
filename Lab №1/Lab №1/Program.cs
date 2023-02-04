using System;

namespace Lab__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_________________________________part 1______________________________________\n");

            Console.WriteLine("Enter coordinates of A");
            Console.WriteLine("Coordinate x");
            double ax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coordinate y");
            double ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates of B");
            Console.WriteLine("Coordinate x ");
            double bx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y = ");
            double by = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter coordinates of C");
            Console.WriteLine("Coordinate x");
            double cx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Coordinate y");
            double cy = Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));
            double AC = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));
            double BC = Math.Sqrt(Math.Pow(bx - cx, 2) + Math.Pow(by - cy, 2));

            double halfPerimeter, areaOfTriangle;
            halfPerimeter = (AB + AC + BC) / 2;
            areaOfTriangle = Math.Pow(halfPerimeter * (halfPerimeter - AB) * (halfPerimeter - AC) * (halfPerimeter - BC), 0.5);
            Console.WriteLine("The area of triangle is " + areaOfTriangle.ToString());


            Console.WriteLine("\n_________________________________part 2______________________________________\n");

            double x1, x2, y;
            Console.WriteLine("Enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            double subroot = Math.Pow(x1, 3) + Math.Pow(x2, 5);
            y = Math.Sqrt(subroot) / 1000 + 65;
            Console.WriteLine("y = " + y.ToString());
          

            Console.WriteLine("\n_________________________________part 3______________________________________\n");

            double alpha, z1, z2;
            Console.WriteLine("Enter alpha: ");
            alpha = Convert.ToInt32(Console.ReadLine());

            z1 = Math.Cos(alpha) + Math.Sin(alpha) + Math.Cos(3 * alpha) + Math.Sin(3 * alpha);
            Console.WriteLine("z1 = " + z1.ToString());
            z2 =  0.25 - 0.25 * Math.Sin((5 / 2) * Math.PI - 8 * alpha);
            Console.WriteLine("z2 = " + z2.ToString());
        }
    }
}
