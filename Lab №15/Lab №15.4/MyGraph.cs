using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__15._4
{
    class MyGraph
    {
        Dictionary<string, List<string>> nodes;

        public MyGraph()
        {
            this.nodes = new Dictionary<string, List<string>>();
        }
        public void CreateByContiguity(int[][] matrix)
        {
            if (matrix.Length != matrix[0].Length)
            {
                return;
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                nodes.Add($"v{i}", new List<string>());
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        nodes[$"v{i}"].Add($"v{j}");
                    }
                }
            }
        }

        public void CreateByІncidence(int[][] matrix)
        {
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            for (int i = 0; i < rows; i++)
            {
                nodes.Add($"v{i}", new List<string>());
            }
            for (int i = 0; i < columns; i++)
            {
                string source = "";
                string dest = "";
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j][i] == 1)
                    {
                        source = $"v{j}";
                    }
                    if (matrix[j][i] == -1)
                    {
                        dest = $"v{j}";
                    }
                    if (matrix[j][i] == 2)
                    {
                        source = $"v{j}";
                        dest = $"v{j}";
                        break;
                    }
                }
                nodes[source].Add(dest);
            }
        }
    
        public void CreateByVectors(Dictionary<string, List<string>> vectors)
        {
            foreach (var item in vectors)
            {
                if (!nodes.ContainsKey(item.Key))
                {
                    nodes.Add(item.Key, new List<string>());
                }
                foreach (var el in item.Value)
                {
                    if (!nodes.ContainsKey(el))
                    {
                        nodes.Add(el, new List<string>());
                    }
                }
            }
            foreach (var item in vectors)
            {
                foreach (var el in item.Value)
                {
                    nodes[item.Key].Add(el);
                }
            }
        }
    
        public void PrintContiguity()
        {
            List<string> all = new List<string>();
            foreach (var item in nodes)
            {
                all.Add(item.Key);
            }

            int[,] matr = new int[nodes.Count, nodes.Count];
            int find = 0;

            foreach (var item in nodes)
            {
                foreach (var el in item.Value)
                {
                    matr[find, all.IndexOf(el)] = 1;
                }
                find++;
            }
            Console.Write("$\t");
            foreach (var item in all)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < nodes.Count; i++)
            {
                Console.Write($"{all[i]}\t");
                for (int j = 0; j < nodes.Count; j++)
                {
                    Console.Write($"{matr[i,j]}\t");
                }
                Console.WriteLine();
            }
        }

        public void PrintІncidence()
        {
            List<string> all = new List<string>();
            int numOfedges = 0;
            foreach (var item in nodes)
            {
                all.Add(item.Key);
                numOfedges += item.Value.Count;
            }
            int[,] matr = new int[nodes.Count, numOfedges];
            int sind = 0;
            foreach (var item in nodes)
            {
                foreach (var el in item.Value)
                {
                    if (item.Key==el)
                    {
                        matr[all.IndexOf(item.Key), sind] = 2;
                    }
                    else
                    {
                        matr[all.IndexOf(item.Key), sind] = 1;
                        matr[all.IndexOf(el), sind] = -1;

                    }
                    sind++;
                }
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                Console.Write($"{all[i]}\t");
                for (int j = 0; j < numOfedges; j++)
                {
                    Console.Write($"{matr[i, j]}\t");
                }
                Console.WriteLine();
            }

        }

        public void PrintVectors()
        {
            foreach (var item in nodes)
            {
                if (item.Value.Count == 0)
                {
                    continue;
                }
                foreach (var el in item.Value)
                {
                    Console.WriteLine($"{item.Key}->{el}");
                }
            }
        }
    }
}
