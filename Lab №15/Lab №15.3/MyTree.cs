using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__15._3
{
    class MyNode
    {
        private string data;
        private MyNode right;
        private MyNode left;

        public MyNode(string data)
        {
            this.data = data;
        }

        public MyNode Right { get => right; set => right = value; }
        public MyNode Left { get => left; set => left = value; }
        public string Data { get => data; set => data = value; }
    }

    class MyTree
    {
        private MyNode head;

        public MyTree()
        {
        }

        public MyTree(string head)
        {
            this.head = new MyNode(head);
        }

        public bool Add(string el)
        {
            var toAdd = new MyNode(el);
            if (head == null)
            {
                head = toAdd;
                return true;
            }
            else
            {
                MyNode prev = null;
                var current = head;
                string path = "";
                while (current!=null)
                {
                    if (toAdd.Data.CompareTo(current.Data) > 0)
                    {
                        prev = current;
                        current = current.Right;
                        path = "Right";
                    }
                    else if (toAdd.Data.CompareTo(current.Data) < 0)
                    {
                        prev = current;
                        current = current.Left;
                        path = "Left";
                    }
                    else
                    {
                        return false;
                    }
                }
                if (path == "Right")
                {
                    prev.Right = toAdd;
                }
                else if (path == "Left")
                {
                    prev.Left = toAdd;
                }
                return true;
            }
        }

        public bool Remove(string el)
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                var current = head;
                MyNode prev = null;
                string path = "";
                while (current!=null)
                {
                    if (el.CompareTo(current.Data) == 0)
                    {
                        if (current.Right != null)
                        {
                            if (current.Right.Left!=null)
                            {
                                var cur = current.Right;
                                MyNode pre = null;
                                while (cur.Left!=null)
                                {
                                    pre = cur;
                                    cur = cur.Left;
                                }
                                cur.Left = current.Left;
                                cur.Right = current.Right;
                                if (prev==null)
                                {
                                    head = cur;
                                    pre.Left = null;
                                    return true;
                                }
                                if (path == "Right")
                                {
                                    prev.Right = cur;
                                }
                                else if (path == "Left")
                                {
                                    prev.Left = cur;
                                }
                                pre.Left = null;
                            }
                            else if (current.Right.Left == null)
                            {
                                if (path == "Right")
                                {
                                    current.Right.Left = current.Left;
                                    prev.Right = current.Right;
                                }
                                else if (path == "Left")
                                {
                                    current.Right.Left = current.Left;
                                    prev.Left = current.Right;
                                }
                            }
                        }
                        else if (current.Right == null)
                        {
                            if (current.Left != null)
                            {
                                if (path == "Right")
                                {
                                    prev.Right = current.Left;
                                }
                                else if(path == "Left")
                                {
                                    prev.Left = current.Left;
                                }
                            }
                            else if (current.Left == null)
                            {
                                if (path == "Right")
                                {
                                    prev.Right = null;
                                }
                                else if (path == "Left")
                                {
                                    prev.Left = null;
                                }
                            }
                        }
                        return true;
                    }
                    else if (el.CompareTo(current.Data) < 0)
                    {
                        prev = current;
                        current = current.Left;
                        path = "Left";
                    }
                    else if(el.CompareTo(current.Data) > 0)
                    {
                        prev = current;
                        current = current.Right;
                        path = "Right";
                    }

                }
                return false;
            }
        }

        public bool Search(string el)
        {
            var current = head;
            while (current!=null)
            {
                if (el.CompareTo(current.Data) == 0)
                {
                    return true;
                }
                else if (el.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else if (el.CompareTo(current.Data) > 0)
                {
                    current = current.Right;
                }
            }
            return false;
        }

        public void InOrder()
        {
            InOrder(head);
        }
        public void PreOrder()
        {
            PreOrder(head);
        }
        public void PostOrder()
        {
            PostOrder(head);
        }


        private void InOrder(MyNode current)
        {
            if (current == null)
            {
                return;
            }
            InOrder(current.Left);
            Console.Write(current.Data + " | ");
            InOrder(current.Right);

        }
        private void PreOrder(MyNode current)
        {
            if (current == null)
            {
                return;
            }
            Console.Write(current.Data + " | ");
            PreOrder(current.Left);
            PreOrder(current.Right);
        }
        private void PostOrder(MyNode current)
        {
            if (current == null)
            {
                return;
            }
            PostOrder(current.Left);
            PostOrder(current.Right);
            Console.Write(current.Data + " | ");
        }
    }
}