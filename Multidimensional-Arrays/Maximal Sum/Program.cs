using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;
            int[,] rectangleMatrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] colNums = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    rectangleMatrix[row, col] = colNums[col];
                }
            }

            for (int row = 0; row < rows-2; row++)
            {
                for (int col = 0; col < cols-2; col++)
                {
                    var sum = rectangleMatrix[row, col]
                        + rectangleMatrix[row, col + 1] + rectangleMatrix[row, col + 2]
                        + rectangleMatrix[row + 1, col] + rectangleMatrix[row + 1, col + 1]
                        + rectangleMatrix[row + 1, col + 2] + rectangleMatrix[row + 2, col]
                        + rectangleMatrix[row + 2, col + 1] + rectangleMatrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{rectangleMatrix[maxRowIndex, maxColIndex]} {rectangleMatrix[maxRowIndex, maxColIndex + 1]} {rectangleMatrix[maxRowIndex, maxColIndex + 2]}");
            Console.WriteLine($"{rectangleMatrix[maxRowIndex + 1, maxColIndex]} {rectangleMatrix[maxRowIndex + 1, maxColIndex + 1]} {rectangleMatrix[maxRowIndex + 1, maxColIndex + 2]}");
            Console.WriteLine($"{rectangleMatrix[maxRowIndex +2, maxColIndex]} {rectangleMatrix[maxRowIndex + 2, maxColIndex + 1]} {rectangleMatrix[maxRowIndex+2, maxColIndex + 2]}");
           

        }
    }
}
