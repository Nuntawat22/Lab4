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
        private int _ageSum = 0;

        public Classroom(string name)
        {
            this.name = name;
        }

        public void addBona2Class(Bona b)
        {
            this.bonas.Add(b);

            /*if (newBona.getGPA()< _minBona.getGPA())
            {
                this._minBona = newBona;
            }*/
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

        public double AvgGPA()
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
        }
        public double MaxGPA()
        {
            double Max = 0;
            foreach (Bona b in this.bonas)
            {

                if (Max < double.Parse(b.getGPA().ToString()))
                {
                    Max = double.Parse(b.getGPA().ToString());
                }

            }
            return Max;
        }

        public double MinGPA()
        {
            //double B = b.getGPA().Tostring();
            double Min = 0;
            foreach (Bona b in this.bonas)
            {

                if (Min < double.Parse(b.getGPA().ToString()))
                {
                    Min = double.Parse(b.getGPA().ToString());
                }

            }
            return Min;
        }
        public string MaxB()
        {
            string resultB = "";
            double MaxB = 0;
            foreach (Bona b in this.bonas)
            {

                if (MaxB >= double.Parse(b.getGPA().ToString()))
                {

                    MaxB = double.Parse(b.getGPA().ToString());
                    resultB = b.getName().ToString();

                }

            }
            return resultB;
        }
    }
}