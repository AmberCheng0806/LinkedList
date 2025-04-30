using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Test
{
    internal class Students<T> : IEnumerable
    {
        public int Count => index;
        public T Name1 { get; set; }
        public T Name2 { get; set; }
        public T Name3 { get; set; }
        public T Name4 { get; set; }
        public T Name5 { get; set; }

        public T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Name1;
                    case 1:
                        return Name2;
                    case 2:
                        return Name3;
                    case 3:
                        return Name4;
                    case 4:
                        return Name5;
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                switch (index)
                {
                    case 0:
                        Name1 = value;
                        break;
                    case 1:
                        Name2 = value;
                        break;
                    case 2:
                        Name3 = value;
                        break;
                    case 3:
                        Name4 = value;
                        break;
                    case 4:
                        Name5 = value;
                        break;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new SequenceEnumerator<T>(this);
        }
        private int index = 0;

        public void Add(T name)
        {
            this[index++] = name;
        }


    }
}
