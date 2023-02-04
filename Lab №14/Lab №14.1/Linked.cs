using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__14._1
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
    public class Linked<T>: IEnumerable<T>
    {
        private Element<T> head;
        private Element<T> tail;
        private int size = 0;

        public int Size { get => size; }

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

        public void MyAddFirst(T element)
        {
            Element<T> el = new Element<T>(element);
            el.Next = head;
            head = el;
            if (size == 0)
            {
                tail = head;
            }
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

        public void MyRemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                head = head.Next;
                if (head == null)
                {
                    return;
                }
                else
                {
                    size--;
                }
            }
        }

        public void MyRemoveLast()
        {
            Element<T> current = head;
            Element<T> prev = null;
            while (true)
            {
                if (current == null)
                {
                    break;
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }
                tail = prev;
                tail.Next = null;
            }

        }

        public void MyClear()
        {
            if (head == null)
            {
                return;
            }
            head.Next = null;
            head = null;
            tail = null;
            size = 0;
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Element<T> current = head;
            while (current!=null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
