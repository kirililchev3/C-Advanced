using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[numOfRows][];

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArr[row] = new int[number.Length];

                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    jaggedArr[row][col] = number[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "end")
                {
                    break;
                }

                var commandParts = command.Split();
                string commandOperator = commandParts[0];
                int commandRow =int.Parse(commandParts[1]);
                int commandCol = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                

                if (commandRow < 0 || commandRow >= jaggedArr.Length 
                    || commandCol < 0 || commandCol >= jaggedArr[commandRow].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (commandOperator == "Add")
                {
                    jaggedArr[commandRow][commandCol] += value;
                }
                else if (commandOperator == "Subtract")
                {
                    jaggedArr[commandRow][commandCol] -= value;
                }
            }

            foreach (var row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
