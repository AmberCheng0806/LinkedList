using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    internal class Village
    {
        public int id;
        public string name;
        public int population;
        public double area;

        public Village(int id, string name, int population, double area)
        {
            this.id = id;
            this.name = name;
            this.population = population;
            this.area = area;
        }

        public string toString()
        {
            return id + "." + name + "(人口: " + population + " 面積: " + area + ")";
        }
    }
}
