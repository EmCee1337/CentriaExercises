using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centria
{
   
    class Person
    {
        public string name { get; }
        private int age { get; set; }
        public int weight { get; set; }
        public int height { get; set; }

        public Person(string initialName)
        {
            this.age = 0;
            this.weight = 0;
            this.height = 0;
            this.name = initialName;
        }

        public void GrowOlder()
        {
            if (this.age <100 )
            {
                this.age = this.age + 1;
            }
        }

        public double BodyMassIndex()
        {
            double heightPerHundred = this.height / 100.0;
            return this.weight / (heightPerHundred * heightPerHundred);
        }

        public bool IsOfLegalAge()
        {
            return this.age >= 18;
        }

        public override string ToString()
        {
            return this.name + ", age " + this.age + " years";
        }

    }
}
