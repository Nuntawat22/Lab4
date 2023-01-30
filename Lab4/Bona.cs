using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Bona
    {
        private string name;
        private int age;
        private int brithYear;
        private double GPA;
        public Bona(string name,int bYear,double gPA) 
        {
            this.name = name;
            this.brithYear = bYear;
            this.age = 2565 - bYear;
            this.GPA = gPA;
        }
        public int getAge() 
        {
            return this.age;
        }
        public string getName()
        {
            return this.name;
        }
        public int getBY()
        {
            return this.brithYear;
        }
        public double getGPA()
        {
            return this.GPA;
        }
    }
}
