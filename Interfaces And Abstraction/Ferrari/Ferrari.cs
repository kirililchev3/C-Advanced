using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : IDriveable
    {
      

        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Model = "488-Spider";
            
        }

        public string Model { get; private set; }
        public string Driver { get; private set; }

        public string PushGas()
        {
            return "Gas!";
        }

        public string UseBreaks()
        {
            return "Brakes!"; 
        }

        public override string ToString()
        {
            return $"{Model}/{UseBreaks()}/{PushGas()}/{Driver}";
        }
    }
}
