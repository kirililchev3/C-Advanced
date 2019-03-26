using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string part, int hours)
        {
            this.Part = part;
            this.Hours = hours;
        }

        public string Part { get; private set; }

        public int Hours { get; private set; }

        public override string ToString()
        {
            return $" Part Name: {Part} Hours Worked: {Hours}";
        }
    }
}
