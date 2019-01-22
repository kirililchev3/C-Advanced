using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int primaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colNumbers[col];
                    if (row == col)
                    {
                        primaryDiagonalSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(primaryDiagonalSum);

           
          
            
        }
    }
}
