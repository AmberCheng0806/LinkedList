using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    internal class SortVillageById : IComparator<Village>
    {
        public bool Compare(Village village1, Village village2)
        {
            return village1.id > village2.id;
        }
    }
}
