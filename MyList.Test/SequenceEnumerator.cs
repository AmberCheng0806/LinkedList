using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Test
{
    internal class SequenceEnumerator<T> : IEnumerator
    {
        private int index = -1;
        public int Count = 0;
        private Students<T> students;
        public object Current => this.students[index];

        public SequenceEnumerator(Students<T> students)
        {
            Count = students.Count;
            this.students = students;
            Reset();
        }

        public bool MoveNext()
        {
            index++;
            return index < Count;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
