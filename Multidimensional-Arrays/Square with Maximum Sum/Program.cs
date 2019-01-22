using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colNums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colNums[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var newSquareSum = matrix[row, col] + matrix[row + 1, col]
                        + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRowIndex,maxColIndex]} {matrix[maxRowIndex,maxColIndex+1]}");
            Console.WriteLine($"{matrix[maxRowIndex + 1,maxColIndex]} {matrix[maxRowIndex +1,maxColIndex+1]}");
            Console.WriteLine(maxSum);
        }
    }
}
