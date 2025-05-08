using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 分頁練習
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // C# => IL Code => JIT => Byte
            //IEnumerable<Mail> datas = GetData();
            //IEnumerable<int> list = new List<int>();

            //string dataName = datas.GetType().FullName;
            //string listName = list.GetType().Name;
            ////foreach (var mail in datas)
            ////{
            ////    Console.WriteLine($"- Received: {mail.Title}");
            ////}
            //Console.Read();
        }

        static IEnumerable<Mail> GetData()
        {
            int buffer_size = 4;  // 4MB
            Random _rnd = new Random();
            Console.WriteLine("start");
            for (int index = 0; index < 10; index++)
            {
                var _buffer = new byte[buffer_size];
                _rnd.NextBytes(_buffer);
                Console.WriteLine($"寄出{index + 1}的信件");
                yield return new Mail()
                {
                    Title = $"buffer[{index}], {buffer_size / 1024 / 1024} MB",
                    Buffer = _buffer,
                };
                Task.Delay(50).Wait();
            }

            //yield break;
        }
    }
}
