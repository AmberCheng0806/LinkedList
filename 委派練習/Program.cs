using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace 委派練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action Func
            //嘗試用上述這兩個東西 來完成今天的js版本練習(打招呼/Map/Filter)
            //思考一下Action/Func 差在哪? 什麼時後應該使用哪一個?

            //1.function SayHello(){
            //console.log('Say Hello')
            //var sayhi = SayHello
            //sayhi
            //void sayHello()
            //{
            //    Console.WriteLine("Say Hello");
            //}
            //Action action = sayHello;
            //action();

            ////function SayHello(times, callback)
            ////{
            ////for (var i = 0; i < times; i++){callback()}
            ////}

            ////SayHello(3, function(){
            ////console.log('Hi,Leo')
            ////});
            //void sayHello2(int times, Action act)
            //{
            //    for (var i = 0; i < times; i++)
            //    {
            //        act();
            //    }
            //}
            //sayHello2(3, () => Console.WriteLine("Hi,Leo"));

            //2.function map(array, callback)
            //{
            //    newArray = [];
            //    for (var i = 0; i < array.length; i++)
            //    {
            //        newArray[i] = callback(array[i]);
            //    }
            //    return newArray;
            //}

            //var result = map([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], function(x) {
            //    return x * 2;
            //});
            //console.log(result);

            //int[] map(int[] array, Func<int, int> fun)
            //{
            //    int[] newArray = new int[array.Length];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        newArray[i] = fun(array[i]);
            //    }
            //    return newArray;
            //}
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = array.map(x => x * 2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3.function filter(array, callback)
            //{
            //    newArray = [];
            //    for (var i = 0; i < array.length; i++)
            //    {
            //        if (callback(array[i]))
            //        {
            //            newArray.push(array[i]);
            //        }
            //    }
            //    return newArray;
            //}

            //var result = filter([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], (x) => x % 2 == 0);
            //console.log(result);

            //int[] filter(int[] array, Func<int, bool> fun)
            //{
            //    List<int> list = new List<int>();
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (fun(array[i]))
            //        {
            //            list.Add(array[i]);
            //        }
            //    }
            //    return list.ToArray();
            //}
            //int[] array2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result2 = array2.filter(x => x % 2 == 0);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}


            // connection timeout
            HttpRequest.get<List<ArticleModel>>("http://jsonplaceholder.typicode.com/posts", response =>
            {
                foreach (ArticleModel model in response)
                {
                    Console.WriteLine(model.title);
                }
            });


            ////建立 WebRequest 並指定目標的 uri
            //WebRequest request = WebRequest.Create("http://jsonplaceholder.typicode.com/posts");
            //// 使用 HttpWebRequest.Create 實際上也是呼叫 WebRequest.Create
            ////WebRequest request = HttpWebRequest.Create("http://jsonplaceholder.typicode.com/posts");
            ////指定 request 使用的 http verb
            //request.Method = "GET";
            ////使用 GetResponse 方法將 request 送出，如果不是用 using 包覆，請記得手動 close WebResponse 物件，避免連線持續被佔用而無法送出新的 request
            //var httpResponse = (HttpWebResponse)request.GetResponse();
            ////使用 GetResponseStream 方法從 server 回應中取得資料，stream 必需被關閉
            ////使用 stream.close 就可以直接關閉 WebResponse 及 stream，但同時使用 using 或是關閉兩者並不會造成錯誤，養成習慣遇到其他情境時就比較不會出錯
            //var streamReader = new StreamReader(httpResponse.GetResponseStream());

            //string result = streamReader.ReadToEnd();
            //List<ArticleModel> res = JsonConvert.DeserializeObject<List<ArticleModel>>(result);


        }


    }
}

