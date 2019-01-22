using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int diff = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colNums = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colNums[col];

                    if (row == col)
                    {
                        primaryDiagonalSum += colNums[col];
                    }

                    if (col == ((size - 1) - row))
                    {
                        secondaryDiagonalSum += colNums[col];
                    }
                }

            }
            diff = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(diff);
        }
    }
}
