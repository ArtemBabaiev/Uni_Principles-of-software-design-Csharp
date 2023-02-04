using System;

namespace Lab__12._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Proffesor prof = new Proffesor("tratata", "math", "physics and math");
            prof.Introduce();
            Console.WriteLine(prof.PutMark());
            prof.PHD();
            Docent doc = new Docent("name", "physic");
            doc.Introduce();
            Console.WriteLine(doc.PutMark());
            var newprof = doc.Upgrade();
            newprof.Introduce();

        }
    }
}
