using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__14._3
{
    class Element<T>
    {
        private T data;
        private Element<T> next;

        public Element(T current)
        {
            Data = current;
        }

        public T Data { get => data; set => data = value; }
        public Element<T> Next { get => next; set => next = value; }
    }
    class LoopList<T>:IEnumerable<T>
    {
        private Element<T> head;
        private Element<T> tail;
        private int size = 0;

        public void Add(T element)
        {
            Element<T> ElNew = new Element<T>(element);
            if (head == null)
            {
                head = ElNew;
                tail = ElNew;
                tail.Next = head;
            }
            else
            {
                ElNew.Next = head;
                tail.Next = ElNew;
                tail = ElNew;
            }
            size++;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Element<T> current = head;
            while (true)
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void PrintShoppers()
        {
            Element<T> current = head;
            do
            {
                Console.WriteLine($"{current.Data.ToString()}");
                current = current.Next;
            } while (current != head);
        }
    }
}
