using System;

namespace Lab__12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var person = new Person("art", "m", 18);
            var student = new Student(5, 4.5, "derj");
            var teacher = new Teacher();
            var head = new Head("math", 12, 4500, "klen", "f", 45);
            person.Show();
            Console.WriteLine("**************************************************");
            student.Show();
            Console.WriteLine("**************************************************");
            teacher.Show();
            Console.WriteLine("**************************************************");
            head.Show();
            Console.WriteLine("**************************************************");

            person.Activity();
            student.Activity();
            teacher.Activity();
            head.Activity();
            
        }
    }
}
