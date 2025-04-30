using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>() { 1, 2, 3 };
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            var result = myList.Select(x => x * 2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var result2 = myList.Where(x => x == 1);
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            //1.介紹何謂迭代模式
            //2.請介紹 IEnumerable IEnumerator 有何區別? 為何要支援能跑forEach的這件事，會需要拆分成兩個interface ?
            //3.請定義何謂物件容器 => 做為一個物件容器最少需要哪些要素?
            //4.我們自己自製的LinkList是物件容器嗎 ? 如果是的話 為甚麼是 ?
            //5.請介紹 IEnumerable IEnumerator ICollection IList 這四個有何區別?


            //myList.Add("A");
            //myList.Add("B");
            //myList.Add("C");
            //myList.Remove("B");
            //myList.Insert(3, "0");

            //MyList<T> newList = new MyList<T>();
            //newList.Add("A");
            //newList.Add("B");
            //newList.Add("C");
            //Node nodeD = new Node("D");
            //Node nodeE = new Node("E");
            //newList.head = nodeD;
            //nodeD.NextNode = nodeE;
            //nodeE.NextNode = myList.head.NextNode;
            //newList.count = 2;


            //myList.AddRange(newList);
            ////myList.AddRange(myList);
            //myList.RemoveRange(newList);



        }

        //static T123 Test<T123>(T123 num)
        //{
        //    num.
        //}
    }
}
