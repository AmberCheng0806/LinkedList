using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students<Info> students = new Students<Info>() {
                new Info(1, "1號"),
                new Info(2, "Leo"),
                new Info(3, "A班"),
                new Info(4, "90"),
                new Info(5, "80"),
            };

            string Name1 = "";
            string Name2 = "";
            string Name3 = "";
            string Name4 = "";
            string Name5 = "";

            //委派

            Stack<Info> stack = new Stack<Info>();
            //students[0] = new Info(1, "1號");
            //students[1] = new Info(2, "Leo");
            //students[2] = new Info(3, "A班");
            //students[3] = new Info(4, "90");
            //students[4] = new Info(5, "80");
            ////students[0] = "Leo";
            //students[1] = "Kelly";
            //students[2] = "Alice";
            //students[3] = "Bob";
            //students[4] = "John";

            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}


            foreach (Info student in students)
            {
                Console.WriteLine($"{student.Name}");
            }
        }
    }
}
