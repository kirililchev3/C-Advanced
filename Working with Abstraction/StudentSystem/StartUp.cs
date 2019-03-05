namespace StudentSystem
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var system = new StudentSystem();
            while (true)
            {
                string command = Console.ReadLine();
                system.ParseCommand(command);
            }
        }
    }
}
