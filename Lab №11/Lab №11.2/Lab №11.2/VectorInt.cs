using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__11._2
{
    class VectorInt
    {
        private int[] IntArray;
        private uint size;
        private int codeError;
        private static uint num_vec = 0;


        public VectorInt()
        {
            this.size = 1;
            this.IntArray = new int[this.size];
            num_vec++;
        }
        public VectorInt(uint size)
        {
            this.size = size;
            this.IntArray = new int[this.size];
            num_vec++;
        }
        public VectorInt(uint size, int toFill)
        {
            this.size = size;
            this.IntArray = new int[this.size];
            for (int i = 0; i < this.size; i++)
            {
                this.IntArray[i] = toFill;
            }
            num_vec++;
        }
        ~VectorInt()
        {
            num_vec--;
            System.Diagnostics.Trace.WriteLine("vetor deletion");
        }

        public void SetElements()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть {i} елемент: ");
                IntArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void SetWithVector(int[] arr)
        {
            IntArray = (int[])arr.Clone();
            size = Convert.ToUInt32(arr.Length);
        }
        public void PrintVector()
        {
            foreach (var el in IntArray)
            {
                Console.Write(el + " | ");
            }
            Console.WriteLine();
        }
        public void SetWithParam(int param)
        {
            for (int i = 0; i < size; i++)
            {
                IntArray[i] = param;
            }
        }
        static public int Quantity()
        {
            return Convert.ToInt32(num_vec);
        }

        public int Size
        {
            get => Convert.ToInt32(size);
        }
        public int CodeError
        {
            get => codeError;
            set => codeError = value;
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < this.size)
                {
                    return IntArray[index];
                }
                else
                {
                    codeError = -1;
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < this.size)
                {
                    IntArray[index] = value;
                }
                else
                {
                    codeError = -1;
                }
            }
        }

        public static VectorInt operator ++(VectorInt obj)
        {
            for (int i = 0; i < obj.size; i++)
            {
                obj[i]++;
            }
            return obj;
        }
        public static VectorInt operator --(VectorInt obj)
        {
            for (int i = 0; i < obj.size; i++)
            {
                obj[i]--;
            }
            return obj;
        }

        public static bool operator true(VectorInt obj)
        {
            if (obj.size == 0)
            {
                return false;
            }
            else
            {
                foreach (var el in obj.IntArray)
                {
                    if (el == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator false(VectorInt obj)
        {
            if (obj.size == 0)
            {
                return true;
            }
            else
            {
                foreach (var item in obj.IntArray)
                {
                    if (item == 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool operator !(VectorInt obj)
        {
            if (obj.Size != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int[] operator ~(VectorInt obj)
        {

            int[] toReturn = new int[obj.Size];
            for (int i = 0; i < obj.Size; i++)
            {
                toReturn[i] = ~obj[i];
            }
            return toReturn;
        }

        public static VectorInt operator +(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] + obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] + obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator +(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] + value;
            }
            return toReturn;
        }
        public static VectorInt operator +(int value, VectorInt obj)
        {
            return obj + value;
        }

        public static VectorInt operator -(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] - obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] - obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator -(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] - value;
            }
            return toReturn;
        }

        public static VectorInt operator *(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] * obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] * obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator *(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] * value;
            }
            return toReturn;
        }
        public static VectorInt operator *(int value, VectorInt obj)
        {
            return obj * value;
        }

        public static VectorInt operator /(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] / obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] / obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator /(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] / value;
            }
            return toReturn;
        }

        public static VectorInt operator %(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] % obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] % obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator %(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] % value;
            }
            return toReturn;
        }

        public static VectorInt operator |(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] | obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] | obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator |(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] | value;
            }
            return toReturn;
        }

        public static VectorInt operator &(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] & obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] & obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator &(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] & value;
            }
            return toReturn;
        }

        public static VectorInt operator ^(VectorInt obj1, VectorInt obj2)
        {
            VectorInt toReturn;
            if (obj1.size >= obj2.size)
            {
                toReturn = new VectorInt(obj1.size);
                for (int i = 0; i < obj1.size; i++)
                {
                    if (i < obj2.size)
                    {
                        toReturn[i] = obj1[i] ^ obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj1[i];
                    }
                }
                return toReturn;
            }
            else
            {
                toReturn = new VectorInt(obj2.size);
                for (int i = 0; i < obj2.size; i++)
                {
                    if (i < obj1.size)
                    {
                        toReturn[i] = obj1[i] ^ obj2[i];
                    }
                    else
                    {
                        toReturn[i] = obj2[i];
                    }
                }
                return toReturn;
            }
        }
        public static VectorInt operator ^(VectorInt obj, int value)
        {
            VectorInt toReturn = new VectorInt(obj.size);
            for (int i = 0; i < obj.size; i++)
            {
                toReturn[i] = obj[i] ^ value;
            }
            return toReturn;
        }

        public static VectorInt operator >>(VectorInt obj, int value)
        {
            for (int i = 0; i < obj.size; i++)
            {
                obj[i] >>= value;
            }
            return obj;
        }
        public static VectorInt operator <<(VectorInt obj, int value)
        {
            for (int i = 0; i < obj.size; i++)
            {
                obj[i] <<= value;
            }
            return obj;
        }

        public static bool operator ==(VectorInt obj1, VectorInt obj2)
        {
            if (obj1.size != obj2.size)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < obj1.size; i++)
                {
                    if (obj1[i] != obj2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator !=(VectorInt obj1, VectorInt obj2)
        {
            if (obj1.size != obj2.size)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < obj1.size; i++)
                {
                    if (obj1[i] != obj2[i])
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool operator >(VectorInt obj1, VectorInt obj2)
        {
            if (obj1.size != obj2.size)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < obj1.size; i++)
                {
                    if (obj1[i] <= obj2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator <(VectorInt obj1, VectorInt obj2)
        {
            if (obj1.size != obj2.size)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < obj1.size; i++)
                {
                    if (obj1[i] >= obj2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator >=(VectorInt obj1, VectorInt obj2)
        {
            if (obj1.size != obj2.size)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < obj1.size; i++)
                {
                    if (obj1[i] < obj2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator <=(VectorInt obj1, VectorInt obj2)
        {
            if (obj1.size != obj2.size)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < obj1.size; i++)
                {
                    if (obj1[i] > obj2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
 }
