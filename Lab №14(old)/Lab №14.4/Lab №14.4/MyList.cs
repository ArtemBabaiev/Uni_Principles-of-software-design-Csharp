using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__14._4
{
    class MyList<Computer>:IEnumerable<Computer>
    {
        private Computer[] arr;
        private int size = 0;
        private int capacity;

        public MyList(int capacity = 8)
        {
            if (capacity<1)
            {
                this.capacity = 1;
            }
            else
            {
                this.capacity = capacity;
            }
            this.arr = new Computer[this.capacity];
        }

        public IEnumerator<Computer> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return arr[i];
            }
        }

        public void MyAdd(Computer element)
        {
            if (size == capacity)
            {
                Computer[] temp = new Computer[capacity * 2];
                for (int i = 0; i < capacity; i++)
                {
                    temp[i] = arr[i];
                }
                arr = temp;
                capacity *= 2;
            }
            arr[size] = element;
            size++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in arr)
            {
                yield return item;
            }
        }
    }
}
