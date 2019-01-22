using System;
using System.Linq;

namespace Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];
            int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int targetRow = bombParameters[0];
            int targetCol = bombParameters[1];
            int radius = bombParameters[2];

            matrix[targetRow, targetCol] = 1;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double result = Math.Pow((row - targetRow), 2) 
                        + Math.Pow((col - targetCol), 2);

                    if (result <= Math.Pow(radius,2))
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            for (int row = 1; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row,col] == 1)
                    {
                        int rowIndex = row;
                        while (true)
                        {
                            rowIndex--;

                            if (rowIndex < 0)
                            {
                                break;
                            }
                            else if (matrix[rowIndex,col] == 1)
                            {
                                break;
                            }
                            else
                            {
                                matrix[rowIndex, col] = 1;
                                matrix[rowIndex + 1, col] = 0;
                            }
                        }
                    }
                }
 
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
