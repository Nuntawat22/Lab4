using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Classroom
    {
        string name;
        List<Bona> bonas = new List<Bona>();

        public Classroom(string name)
        {
        this.name = name;
        }
        public void addBona2Class(Bona b)
        {
            this.bonas.Add(b);
        }
        public string showAllBonainClass()
        {
            string result = "";
            foreach(Bona b in this.bonas)
            {
                result += b.getName() + "\r\n";
            }
            return result;
        }
    }
}