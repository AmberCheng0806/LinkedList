using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        public T Data;
        public Node<T> NextNode;
        public Node(T data)
        {
            this.Data = data;
            this.NextNode = null;
        }
    }
}
