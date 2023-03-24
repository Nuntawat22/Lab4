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

        private Bona _minBona = new Bona("Max", 1, 9999);
        private Bona Min = null;
        private Bona Max = null;
        private int _ageSum = 0;
        

        public Classroom(string name)
        {
            this.name = name;
        }

        public void addBona2Class(Bona b)
        {
            this.bonas.Add(b);
            this._ageSum += b.getAge();

            if (Max == null || b.getGPA() > Max.getGPA())
            {

                this.Max = b;

            }
            if (Min == null || b.getGPA() < Min.getGPA())
            {

                this.Min = b;

            }
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

        public int TotalAge()
        {
            int result = 0;
            foreach (Bona b in this.bonas)
            {

                result += +b.getAge();

            }
            return result;
        }

        /*public double AvgGPA()
        {
            double result = 0;
            int MC = 0;
            foreach (Bona b in this.bonas)
            {

                result = (result + b.getGPA());
                MC = MC + 1;
            }
            result = result / MC;
            return result;
        }*/

        public string NameMaxGPA()
        {
            return this.Max.getName();
        }

        public double MaxGPA()
        {
            if (Max == null)
            {
                return 0; // 
            }
            return this.Max.getGPA();
        }

        public string NameMinGPA()
        {
            return this.Min.getName();
        }

        public double MinGPA()
        {
            if (Min == null)
            {
                return 0;
            }
            return this.Min.getGPA();
        }

        /*public string MaxHigh()
        {
            string resultHigh = "";
            double MaxHigh = 0;
            foreach (Bona b in this.bonas)
            {

                if (MaxHigh >= double.Parse(b.getGPA().ToString()))
                {

                    MaxHigh = double.Parse(b.getGPA().ToString());
                    resultHigh = b.getName().ToString();

                }

            }
            return resultHigh;
        }*/

        public int getBonaCount()
        {
            return this.bonas.Count;
        }

        public int getAgeSumaryOfThisClass()
        {
            return this._ageSum;
        }

        public double getAgeAverage()
        {
            return this._ageSum / this.bonas.Count;
        }

        public double GPAAge()
        {
            double _avg = 0.0;
            foreach (Bona p in this.bonas)
            {
                _avg += p.getGPA();
            }
            return _avg / this.bonas.Count;
        }
    }
}