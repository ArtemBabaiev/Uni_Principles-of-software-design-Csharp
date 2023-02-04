using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab__11._1
{
    public class Point
    {
        private double x;
        private double y;
        private string color;
        private List<object> data;

        public Point(double x, double y, string color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.data = new List<object> { this.x, this.y, this.color };
        }
        public Point()
        {
            this.x = 0;
            this.y = 0;
            this.color = "black";
            this.data = new List<object> { this.x, this.y, this.color };
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

        public void PrintCoord()
        {
            Console.WriteLine($"Координати Х: {x} Координати Y: {y}");
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
        public object this[int index]
        {
            get
            {
                if (index < 0 || index > 2)
                {
                    throw new InvalidIndex("Not correct index");
                }
                else
                {
                    return data[index];
                }
            }
            set
            {
                if (index < 0 || index > 2)
                {
                    throw new InvalidIndex("Not correct index");
                }
                else
                {
                    data[index] = value;
                    if (index == 0)
                    {
                        x = Convert.ToDouble(value);
                    }
                    else if (index == 1 )
                    {
                        y = Convert.ToDouble(value);
                    }
                    else
                    {
                        color = value.ToString();
                    }
                }
            }
        }

        public static Point operator ++(Point obj)
        {
            obj.x++;
            obj.y++;
            return obj;
        }
        public static Point operator --(Point obj)
        {
            obj.x--;
            obj.y--;
            return obj;
        }
        public static bool operator true(Point obj)
        {
            if (obj.x == obj.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Point obj)
        {
            if (obj.x != obj.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Point operator +(Point obj, int a)
        {
            obj.x+=a;
            obj.y+=a;
            return obj;
        }
        public override string ToString()
        {
            return $"{x} {y} {color}";
        }
        public static Point ToPoint(string str)
        {
            string[] arr = Regex.Split(str, @"[ ]");
            return new Point(Convert.ToDouble(arr[0]), Convert.ToDouble(arr[1]), arr[2]);
        }
    }
}
