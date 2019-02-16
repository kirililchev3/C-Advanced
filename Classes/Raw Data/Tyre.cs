using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tyre
    {
        public double pressure;
        public int age;

        public Tyre(double pressure,int age)
        {
            this.pressure = pressure;
            this.age = age;
        }
    }
}
