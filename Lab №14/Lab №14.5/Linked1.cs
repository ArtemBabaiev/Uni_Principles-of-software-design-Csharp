using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__14._5
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
        internal Element<T> Next { get => next; set => next = value; }
    }
    public class Linked1<T>
    {
        private Element<T> head;
        private Element<T> tail;
        private int size = 0;
        public void MyAddLast(T element)
        {
            Element<T> el = new Element<T>(element);
            if (head == null)
            {
                head = el;
            }
            else
            {
                tail.Next = el;
            }
            tail = el;
            size++;
        }

        public bool MyAddAfter(T after, T element)
        {
            Element<T> el = new Element<T>(element);
            Element<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(after))
                {
                    el.Next = current.Next;
                    current.Next = el;
                    size++;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void MyRemove(T element)
        {
            Element<T> current = head;
            Element<T> prev = null;

            while (current != null)
            {
                if (current.Data.Equals(element))
                {
                    if (prev != null)
                    {
                        prev.Next = current.Next;
                        if (current.Next == null)
                            tail = prev;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    size--;
                    return;
                }

                prev = current;
                current = current.Next;
            }
            return;
        }

        public bool MySearch(T element)
        {
            Element<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(element))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void MyPrint()
        {
            Element<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data.ToString());
                current = current.Next;
            }
        }
    }
}