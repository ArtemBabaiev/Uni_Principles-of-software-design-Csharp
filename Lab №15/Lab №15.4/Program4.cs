using System;
using System.Collections.Generic;

namespace Lab__15._4
{
    class Program4
    {
        static void Main(string[] args)
        {
            var graphCont = new MyGraph();
            int[][] cont = new int[6][];
            cont[0] = new int[] { 1, 0, 0, 0, 0, 1 };
            cont[1] = new int[] { 1, 1, 0, 1, 0, 1 };
            cont[2] = new int[] { 1, 0, 0, 1, 1, 0 };
            cont[3] = new int[] { 0, 0, 0, 0, 1, 0 };
            cont[4] = new int[] { 0, 0, 0, 0, 0, 0 };
            cont[5] = new int[] { 0, 0, 0, 0, 0, 0 };
            graphCont.CreateByContiguity(cont);

            graphCont.PrintІncidence();

            Console.WriteLine("**************************************************************************************************************");
            var graphInd = new MyGraph();
            int[][] inde = new int[6][];
            inde[0] = new int[] { 2,  1, -1, 0,  0,  0, -1,  0,  0,  0};
            inde[1] = new int[] { 0,  0,  1, 2,  1,  1,  0,  0,  0,  0};
            inde[2] = new int[] { 0,  0,  0, 0,  0,  0,  1,  1,  1,  0};
            inde[3] = new int[] { 0,  0,  0, 0,  0, -1,  0,  0, -1,  1};
            inde[4] = new int[] { 0,  0,  0, 0,  0,  0,  0, -1,  0, -1};
            inde[5] = new int[] { 0, -1,  0, 0, -1,  0,  0,  0,  0,  0};
            graphInd.CreateByІncidence(inde);

            graphInd.PrintVectors();
            Console.WriteLine("**************************************************************************************************************");
            
            var graphVec = new MyGraph();
            Dictionary<string, List<string>> vectors = new Dictionary<string, List<string>>();
            vectors.Add("a", new List<string>(new string[] { "a", "f"}));
            vectors.Add("b", new List<string>(new string[] { "a", "b", "d", "f" }));
            vectors.Add("c", new List<string>(new string[] { "a", "d", "e" }));
            vectors.Add("d", new List<string>(new string[] { "e" }));
            graphVec.CreateByVectors(vectors);

            graphVec.PrintContiguity();
            Console.WriteLine("**************************************************************************************************************");


            Console.ReadLine();

        }
    }
}
