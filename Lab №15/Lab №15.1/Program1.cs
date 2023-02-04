using System;
using System.IO;
using System.Collections.Generic;

namespace Lab__15._1
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            File.WriteAllText("formula.txt", "((1+2)-4*(a-3)/(2-7+6)");
            Stack<char> brackets = new Stack<char>();
            List<int> positions = new List<int>();
            string text = File.ReadAllText("formula.txt");
            bool isBalanced = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    brackets.Push(text[i]);
                }
                else if (text[i] == ')')
                {
                    if (brackets.Count == 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    else
                    {
                        brackets.Pop();
                        positions.Add(i);
                    }
                }
            }
            if (isBalanced && brackets.Count == 0)
            {
                Console.WriteLine("Збалансоване");
                Console.WriteLine("Позиції закриваючих дужок");
                foreach (var item in positions)
                {
                    Console.Write($"{item} | ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Не збалансоване");
            }
        }
    }
}
