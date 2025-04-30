using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Village appleFarm = new Village(3, "apple farm", 32, 5.1);
            Village barnField = new Village(1, "barn field", 22, 1.7);
            Village capeValley = new Village(2, "cape valley", 10, 10.2);
            List<Village> villages = new List<Village>() { appleFarm, barnField, capeValley };

            //void QuickSortByCondition(List<Village> list, Func<Village, Village, bool> func)
            //{
            //    QuickSort(list, func, 0, list.Count - 1);
            //}

            //void QuickSort(List<Village> list, Func<Village, Village, bool> func, int left, int right)
            //{
            //    int L = left;
            //    int R = right;
            //    Village start = list[left];
            //    while (R != L)
            //    {
            //        while (func(list[R], start))
            //        {
            //            R--;
            //        }
            //        (list[L], list[R]) = (list[R], list[L]);
            //        while (func(start, list[L]))
            //        {
            //            L++;
            //        }
            //        (list[L], list[R]) = (list[R], list[L]);
            //    }
            //    if (L != left)
            //    {
            //        QuickSort(list, func, left, L - 1);
            //    }
            //    if (R != right)
            //    {
            //        QuickSort(list, func, R + 1, right);
            //    }
            //}
            void QuickSort<T>(List<T> list, IComparator<T> comparator, int left, int right)
            {
                int L = left;
                int R = right;
                var start = list[left];
                while (R != L)
                {
                    while (comparator.Compare(list[R], start))
                    {
                        R--;
                    }
                    (list[L], list[R]) = (list[R], list[L]);
                    while (comparator.Compare(start, list[L]))
                    {
                        L++;
                    }
                    (list[L], list[R]) = (list[R], list[L]);
                }
                if (L != left)
                {
                    QuickSort(list, comparator, left, L - 1);
                }
                if (R != right)
                {
                    QuickSort(list, comparator, R + 1, right);
                }
            }

            QuickSort<Village>(villages, new SortVillageByName(), 0, villages.Count - 1);

            //QuickSortByCondition(villages, (x, y) => { return x.id > y.id; });

            //QuickSortByCondition(villages, (x, y) => { return x.population > y.population; });

            //QuickSortByCondition(villages, (x, y) =>
            //{
            //    if (x.name[0] != y.name[0])
            //    {
            //        return x.name[0] > y.name[0];
            //    }
            //    return x.name.Sum(z => z) > y.name.Sum(p => p);
            //});

            foreach (var item in villages)
            {
                Console.WriteLine(item.toString());
            }
        }
    }
}
