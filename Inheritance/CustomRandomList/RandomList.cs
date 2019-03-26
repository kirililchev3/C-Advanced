using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }

        public string RemoveRandom()
        {
            int index = random.Next(0, this.Count);
            string element = this[index];
            this.RemoveAt(index);

            return element;
        }
    }
}
