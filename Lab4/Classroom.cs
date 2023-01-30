using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Classroom
    {
        private string name;
        private List<Bona> bonas = new List<Bona>();

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
            foreach (Bona b in this.bonas)
            {
                result += b.getName() + "\r\n";
            }
            return result;
        }
        public int m3Age()
        {
            int result = 0;
            foreach (Bona b in this.bonas)
            {
                result += +b.getAge();
            }
            return result;
        }
        public double max()
        {
            double max = 0;
            foreach (Bona b in this.bonas)
            {
                if (max < double.Parse(b.getGPA().ToString()))
                {
                    max = double.Parse(b.getGPA().ToString());
                }
            }
            return max;
        }
        public double min()
        {
            double min = 0;
            foreach (Bona b in this.bonas)
            {
                if (min < double.Parse(b.getGPA().ToString()))
                {
                    min = double.Parse(b.getGPA().ToString());
                }
            }
            return min;
        }
        public double Avg()
        {
            double Avg = 0;
            foreach (Bona b in this.bonas)
            {
                if (Avg < double.Parse(b.getGPA().ToString()))
                {
                    Avg = double.Parse(b.getGPA().ToString());
                }
            }
            return Avg;
        }
    }
}