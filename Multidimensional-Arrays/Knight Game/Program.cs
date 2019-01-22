using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string element = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = element[col];
                }
            }

            int attackKnightsCount = 0;
            int maxAttackedKnightsCount = -1;
            int knightRow = 0;
            int knightCol = 0;
            int count = 0;

            while (true)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row,col] == 'K')
                        {
                            if (CheckCell(row-2,col-1,matrix))
                            {
                                if (matrix[row-2,col-1] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }

                            if (CheckCell(row-2,col+1,matrix))
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }

                            if (CheckCell(row-1,col-2,matrix))
                            {
                                if (matrix[row-1,col-2] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }
                            if (CheckCell(row-1,col+2,matrix))
                            {
                                if (matrix[row-1,col+2] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }

                            if (CheckCell(row+1,col-2,matrix))
                            {
                                if (matrix[row+1,col-2] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }

                            if (CheckCell(row+1,col+2,matrix))
                            {
                                if (matrix[row+1,col+2] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }

                            if (CheckCell(row+2,col-1,matrix))
                            {
                                if (matrix[row+2,col-1] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }

                            if (CheckCell(row+2,col+1,matrix))
                            {
                                if (matrix[row+2,col+1] == 'K')
                                {
                                    attackKnightsCount++;
                                }
                            }
                        }
                        if (attackKnightsCount > maxAttackedKnightsCount)
                        {
                            maxAttackedKnightsCount = attackKnightsCount;
                            knightRow = row;
                            knightCol = col;
                        }

                        attackKnightsCount = 0;
                    }
                }

                if (maxAttackedKnightsCount > 0)
                {
                    matrix[knightRow, knightCol] = 'O';
                    count++;
                    maxAttackedKnightsCount = 0;
                }
                else
                {
                    Console.WriteLine(count);
                    return;
                }
            }
        }

        private static bool CheckCell(int row, int col, char[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
