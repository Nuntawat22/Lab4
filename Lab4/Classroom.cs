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
        private int AgeSum = 0;
        

        public Classroom(string name)
        {
            this.name = name;
        }



        // Classroom
        public void addBona2Class(Bona b)
        {
            this.bonas.Add(b);
            this.AgeSum += b.getAge();

            if (Max == null || b.getGPA() > Max.getGPA())
            {

                this.Max = b;

            }
            if (Min == null || b.getGPA() < Min.getGPA())
            {

                this.Min = b;

            }
        }



        // Text Box Contacts 
        public string showAllBonainClass()
        {
            string result = "";
            foreach (Bona b in this.bonas)
            {

                result += b.getName() + "\r\n";

            }
            return result;
        }



        // Text Box Total 
        public int TotalAge()
        {
            int Array = 0;
            foreach (Bona b in this.bonas)
            {

                Array += +b.getAge();

            }
            return Array;
        }



        // Text Box Avg
        public double GPAAge()
        {
            double _avg = 0.0;
            foreach (Bona p in this.bonas)
            {
                _avg += p.getGPA();
            }
            return _avg / this.bonas.Count;
        }



        // Name List High grade
        public string NameMaxGPA()
        {
            return this.Max.getName();
        }



        // Text Box Max
        public double MaxGPA()
        {
            if (Max == null)
            {
                return 0; // 
            }
            return this.Max.getGPA();
        }



        // Name List Low grade
        public string NameMinGPA()
        {
            return this.Min.getName();
        }



        // Text Box Min
        public double MinGPA()
        {
            if (Min == null)
            {
                return 0;
            }
            return this.Min.getGPA();
        }
    }
}