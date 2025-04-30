using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    internal class SortVillageByName : IComparator<Village>
    {
        public bool Compare(Village village1, Village village2)
        {
            if (village1.name[0] != village2.name[0])
            {
                return village1.name[0] > village2.name[0];
            }
            return village1.name.Sum(z => z) > village2.name.Sum(p => p);
        }
    }
}
