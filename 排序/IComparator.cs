using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    internal interface IComparator<T>
    {
        bool Compare(T village1, T village2);
    }
}
