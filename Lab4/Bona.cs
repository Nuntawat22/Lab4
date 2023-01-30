using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Bona
    {
        private string name;
        private int age;
        private int brithYear;

        public Bona(string name,int bYear) 
        {
            this.name = name;
            this.brithYear = bYear;
            this.age = 2565 - bYear;
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
    }
}
