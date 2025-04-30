using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    internal class MyList<T> : IEnumerable, IEnumerator
    {
        public Node<T> head = null;
        public int Count => count;

        public object Current => this[index];

        private int count = 0;

        private int index = -1;

        public T this[int index]
        {
            get
            {
                if (index > count - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Node<T> thisNode = head;
                for (int i = 1; i <= index; i++)
                {
                    thisNode = thisNode.NextNode;
                }
                return thisNode.Data;
            }
            set
            {
                if (index > count - 1 || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Node<T> thisNode = head;
                for (int i = 1; i <= index; i++)
                {
                    thisNode = thisNode.NextNode;
                }
                thisNode.Data = value;
            }
        }
        public void Add(T str)
        {
            count++;
            if (head == null)
            {
                head = new Node<T>(str);
                return;
            }
            Node<T> thisNode = head;
            while (thisNode.NextNode != null)
            {
                thisNode = thisNode.NextNode;
            }
            thisNode.NextNode = new Node<T>(str);
        }

        public void Remove(T str)
        {
            if (head.Data.Equals(str))
            {
                head = head.NextNode;
                return;
            }
            Node<T> thisNode = head;
            Node<T> lastNode = null;
            while (thisNode.Data.Equals(str))
            {
                lastNode = thisNode;
                thisNode = thisNode.NextNode;
            }
            lastNode.NextNode = thisNode.NextNode;
            count--;
        }

        public void Insert(int index, T str)
        {
            if (count < index)
            {
                return;
            }
            Node<T> newNode = new Node<T>(str);
            Node<T> thisNode = head;
            if (index == 0)
            {
                head = newNode;
                head.NextNode = thisNode;
                return;
            }
            Node<T> lastNode = null;
            int number = 0;
            while (number != index)
            {
                lastNode = thisNode;
                thisNode = thisNode.NextNode;
                number++;
            }
            lastNode.NextNode = newNode;
            newNode.NextNode = thisNode;
            count++;
        }

        public void AddRange(MyList<T> newList)
        {
            //mylist==newlist

            Node<T> last = GetLast();
            //Node originalLast = last;
            //int number = 0;
            //Node thisNode = newList.head;
            //while (number < newList.count)
            //{
            //    if (thisNode.NextNode != null && number != 0)
            //    {
            //        thisNode = thisNode.NextNode;
            //    }
            //    last.NextNode = thisNode;
            //    number++;
            //    count++;
            //    last = GetLast();
            //}

            last.NextNode = newList.head;
            Node<T> node1 = head;
            Node<T> node2 = head;
            while (node2.NextNode != null && node2.NextNode.NextNode != null)
            {
                node1 = node1.NextNode;
                node2 = node2.NextNode.NextNode;
                if (node1 == node2)
                {
                    last.NextNode = null;
                    return;
                }
            }
            count += newList.count;
        }

        public void RemoveRange(MyList<T> newList)
        {
            //int number = 0;
            //Node thisNode = newList.head;
            //while (number < newList.count)
            //{
            //    Remove(thisNode.Data);
            //    thisNode = thisNode.NextNode;
            //    number++;
            //}

            for (int i = 0; i < newList.count; i++)
            {
                Remove(newList[i]);
                count--;
            }
        }

        public Node<T> GetLast()
        {
            Node<T> last = head;
            for (int i = 0; i < count - 1; i++)
            {
                last = last.NextNode;
            }
            return last;
        }


        //  list.Count();
        //  list.ElementAt(0);
        //  list.First();
        public bool Contains(T str)
        {
            Node<T> thisNode = head;
            while (thisNode != null)
            {
                if (thisNode.Data.Equals(str))
                {
                    return true;
                }
                thisNode = thisNode.NextNode;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (count < index)
            {
                return;
            }
            if (index == 0)
            {
                head = head.NextNode;
                return;
            }
            Node<T> thisNode = head;
            Node<T> lastNode = null;
            int number = 0;
            while (number != index)
            {
                lastNode = thisNode;
                thisNode = thisNode.NextNode;
                number++;
            }
            lastNode.NextNode = thisNode.NextNode;
            count--;
        }

        public void Clear()
        {
            //head = null;
            while (head != null)
            {
                head = head.NextNode;
                count--;
            }
        }

        public int IndexOf(T str)
        {
            Node<T> thisNode = head;
            int index = 0;
            while (thisNode != null)
            {
                if (thisNode.Data.Equals(str))
                {
                    return index;
                }
                thisNode = thisNode.NextNode;
                index++;
            }
            return -1;
        }

        public int LastIndexOf(T str)
        {
            Node<T> thisNode = head;
            int index = 0;
            int last = -1;
            while (thisNode != null)
            {
                if (thisNode.Data.Equals(str))
                {
                    last = index;
                }
                thisNode = thisNode.NextNode;
                index++;
            }
            return last;
        }

        public void Reverse()
        {
            Node<T> thisNode = head;
            Node<T> last = null;
            Node<T> next = head;
            while (thisNode != null)
            {
                next = thisNode.NextNode;
                thisNode.NextNode = last;
                last = thisNode;
                thisNode = next;
            }
            head = last;
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        public bool MoveNext()
        {
            index++;
            return index < this.Count;
        }

        public void Reset()
        {
            index = -1;
        }

        public MyList<T2> Select<T2>(Func<T, T2> fun)
        {
            MyList<T2> myList = new MyList<T2>();
            foreach (T item in this)
            {
                myList.Add(fun(item));
            }
            return myList;
        }

        public MyList<T> Where(Func<T, bool> fun)
        {
            MyList<T> myList = new MyList<T>();
            foreach (T item in this)
            {
                if (fun(item))
                {
                    myList.Add(item);
                }
            }
            return myList;
        }
    }
}
