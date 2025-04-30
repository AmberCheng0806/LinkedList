using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Test
{
    internal class ReverseEnumerator<T> : IEnumerator
    {
        private int index = 0;
        public int Count = 0;
        private Students<T> students;
        public object Current => this.students[index];

        public ReverseEnumerator(Students<T> students)
        {
            Count = students.Count;
            this.students = students;
            Reset();
        }

        public bool MoveNext()
        {
            index--;
            return index >= 0;
        }

        public void Reset()
        {
            index = Count;
        }
    }
}
