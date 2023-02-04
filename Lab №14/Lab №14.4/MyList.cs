using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__14._4
{
    class MyList<T> : IEnumerable<T>
    {
        private T[] arr;
        private int size = 0;
        private int capacity;

        public MyList(int capacity = 8)
        {
            if (capacity < 1)
            {
                this.capacity = 1;
            }
            else
            {
                this.capacity = capacity;
            }
            this.arr = new T[this.capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return arr[i];
            }
        }

        public void MyAdd(T element)
        {
            if (size == capacity)
            {
                T[] temp = new T[capacity * 2];
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
