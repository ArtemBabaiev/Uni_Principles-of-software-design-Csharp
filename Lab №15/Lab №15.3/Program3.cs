using System;

namespace Lab__15._3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var tree = new MyTree();
            tree.Add("4MyComputer");
            tree.Add("2C");
            tree.Add("5D");
            tree.Add("1ProgramFiles");
            tree.Add("3ProgramFiles(x86)");
            tree.Add("7University");
            tree.Add("6PKPZ");
            tree.Add("8VM");


            tree.InOrder();
            Console.WriteLine();
            tree.PreOrder();
            Console.WriteLine();
            tree.PostOrder();
            Console.WriteLine();
            Console.WriteLine(tree.Search("2C"));
            Console.WriteLine(tree.Search("2E"));
        }
    }
}
