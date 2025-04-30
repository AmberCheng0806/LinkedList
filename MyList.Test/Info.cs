using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList.Test
{
    internal class Info
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Info(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
