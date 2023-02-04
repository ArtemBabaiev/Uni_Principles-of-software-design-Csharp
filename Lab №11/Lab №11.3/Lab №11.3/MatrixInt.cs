using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__11._3
{
    class MatrixInt
    {
        private int[,] IntArray;
        private int n, m;
        private int codeError;
        private static int num_m;

        public MatrixInt()
        {
            this.IntArray = new int[1, 1];
            this.n = 1;
            this.m = 1;
            num_m++;
        }
        public MatrixInt(int n, int m)
        {
            this.IntArray = new int[n, m];
            this.n = n;
            this.m = m;
            num_m++;
        }
        public MatrixInt(int n, int m, int toFill)
        {
            this.IntArray = new int[n, m];
            this.n = n;
            this.m = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    IntArray[i, j] = toFill;
                }
            }
            num_m++;
        }
        ~MatrixInt()
        {
            num_m--;
            System.Diagnostics.Trace.WriteLine("Матрицю видалено");
        }
        public void SetElements()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Введіть ({i};{j}): ");
                    IntArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{IntArray[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static public int Quantity()
        {
            return num_m;
        }
        public void SetWithParametr(int param)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    IntArray[i, j] = param;
                }
            }
        }

        public int[] Size
        {
            get => new int[] { n, m };
        }
        public int CodeError
        {
            get => codeError;
            set => codeError = value;
        }

        public int this[int r, int c]
        {
            get
            {
                if (r < n && r >= 0 && c >= 0 && c < m)
                {
                    return this.IntArray[r, c];
                }
                else
                {
                    this.codeError = -1;
                    return 0;
                }
            }
            set
            {
                if (r < n && r >= 0 && c >= 0 && c < m)
                {
                    this.IntArray[r, c] = value;
                }
                else
                {
                    this.CodeError = -1;
                }
            }
        }
        public int this[int k]
        {
            get
            {
                int i = k / n;
                int j = k % n;
                if (i < n && i >= 0 && j >= 0 && j < m)
                {
                    return this.IntArray[i, j];
                }
                else
                {
                    this.CodeError = -1;
                    return 0;
                }
            }
            set
            {
                int i = k / n;
                int j = k % n;
                if (i < n && i >= 0 && j >= 0 && j < m)
                {
                    this.IntArray[i, j] = value;
                }
                else
                {
                    this.CodeError = -1;
                }
            }
        }

        public static MatrixInt operator ++(MatrixInt obj)
        {
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    obj[i, j]++;
                }
            }
            return obj;
        }
        public static MatrixInt operator --(MatrixInt obj)
        {
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    obj[i, j]--;
                }
            }
            return obj;
        }

        public static bool operator true(MatrixInt obj)
        {
            if (obj.m == 0 || obj.n == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < obj.n; i++)
                {
                    for (int j = 0; j < obj.m; j++)
                    {
                        if (obj[i, j] == 0)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

        }
        public static bool operator false(MatrixInt obj)
        {
            if (obj.m == 0 || obj.n == 0)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < obj.n; i++)
                {
                    for (int j = 0; j < obj.m; j++)
                    {
                        if (obj[i, j] == 0)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public static bool operator !(MatrixInt obj)
        {
            if (obj.n == 0 || obj.m == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int[,] operator ~(MatrixInt obj)
        {
            int[,] toReturn = (int[,])obj.IntArray.Clone();
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = ~obj[i, j];
                }
            }
            return toReturn;
        }

        public static MatrixInt operator +(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] + obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator +(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] + value;
                }
            }
            return toReturn;
        }
        
        public static MatrixInt operator -(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] - obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator -(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] - value;
                }
            }
            return toReturn;
        }

        public static MatrixInt operator *(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.n)
            {
                var toReturn = new MatrixInt(obj1.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        for (int k = 0; k < obj2.n; k++)
                        {
                            toReturn[i, j] += obj1[i, k] * obj2[k, j];
                        }
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator *(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] * value;
                }
            }
            return toReturn;
        }
        public static MatrixInt operator *(MatrixInt obj1, VectorInt obj2)
        {
            if (obj1.m == obj2.Size)
            {
                var toReturn = new MatrixInt(obj1.n, 1);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        toReturn[i, 0] += obj1[i, j] * obj2[j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }

        public static MatrixInt operator /(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] / obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator /(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] / value;
                }
            }
            return toReturn;
        }

        public static MatrixInt operator %(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] % obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator %(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] % value;
                }
            }
            return toReturn;
        }

        public static MatrixInt operator |(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] | obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator |(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] | value;
                }
            }
            return toReturn;
        }

        public static MatrixInt operator &(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] & obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator &(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] & value;
                }
            }
            return toReturn;
        }

        public static MatrixInt operator ^(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                var toReturn = new MatrixInt(obj2.n, obj2.m);
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj2.m; j++)
                    {
                        toReturn[i, j] = obj1[i, j] ^ obj2[i, j];
                    }
                }
                return toReturn;
            }
            else
            {
                return obj1;
            }
        }
        public static MatrixInt operator ^(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] ^ value;
                }
            }
            return toReturn;
        }

        public static MatrixInt operator >>(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] >> value;
                }
            }
            return toReturn;
        }
        public static MatrixInt operator <<(MatrixInt obj, int value)
        {
            var toReturn = new MatrixInt(obj.n, obj.m);
            for (int i = 0; i < obj.n; i++)
            {
                for (int j = 0; j < obj.m; j++)
                {
                    toReturn[i, j] = obj[i, j] << value;
                }
            }
            return toReturn;
        }

        public static bool operator ==(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        if (obj1[i, j] != obj1[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else 
            {
                return false;
            }
        }
        public static bool operator !=(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        if (obj1[i, j] != obj1[i, j])
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        if (obj1[i, j] <= obj1[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        if (obj1[i, j] >= obj1[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        if (obj1[i, j] < obj1[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(MatrixInt obj1, MatrixInt obj2)
        {
            if (obj1.m == obj2.m && obj1.n == obj2.n)
            {
                for (int i = 0; i < obj1.n; i++)
                {
                    for (int j = 0; j < obj1.m; j++)
                    {
                        if (obj1[i, j] > obj1[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
