using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委派練習
{
    internal static class Extension
    {
        public static IEnumerable<int> map(this IEnumerable<int> datas, Func<int, int> fun)
        {
            List<int> list = new List<int>();
            IEnumerator<int> enumerator = datas.GetEnumerator();
            while (enumerator.MoveNext())
            {
                list.Add(fun(enumerator.Current));
            }
            return list;
        }

        public static IEnumerable<int> filter(this IEnumerable<int> datas, Func<int, bool> fun)
        {
            List<int> list = new List<int>();
            IEnumerator<int> enumerator = datas.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (fun(enumerator.Current))
                {
                    list.Add(enumerator.Current);
                }
            }
            return list;
        }
    }
}
