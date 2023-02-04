using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__15._2
{
    class DoubleQueue<T>:IEnumerable<T>
    {
        private List<T> lst = new List<T>();
        public void PushFront(T el)
        {
            lst.Insert(0, el);
        }
        public void PushBack(T el)
        {
            lst.Add(el);
        }
        public T PopFront()
        {
            if (lst.Count==0)
            {
                return default(T);
            }
            else
            {
                var temp = lst[0];
                lst.RemoveAt(0);
                return temp;
            }
        }
        public T PopBack()
        {
            if (lst.Count == 0)
            {
                return default(T);
            }
            else
            {
                var temp = lst[lst.Count - 1];
                lst.RemoveAt(lst.Count - 1);
                return temp;
            }
        }
        public T Front
        {
            get => lst.Count != 0 ? lst[0] : default(T);
        }
        public T Back
        {
            get => lst.Count != 0 ? lst[lst.Count - 1] : default(T);
        }
        public int Size
        {
            get => lst.Count;
        }
        public void Clear()
        {
            lst.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)lst).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)lst).GetEnumerator();
        }
    }
}
