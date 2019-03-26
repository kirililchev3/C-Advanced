using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var randomList = new RandomList();
            randomList.Add("Test");
            randomList.Add("Pesho");
            randomList.Add("Ivan");

            Console.WriteLine(randomList.RemoveRandom());
        }
    }
}
