using System;

namespace LookingForBananas
{
    public class MonkeyIsland
    {
        /// <summary>
        /// Calculate how many bananas based on the passed matrix
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <returns></returns>
        public int GetMaxBananas(int[,] matrix)
        {
            if (matrix == null) return 0; 

            // matrix size
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);

            // Create a table for storing
            int[,] bananaTable = new int[m, n];

            for (int col = n - 1; col >= 0; col--)
            {
                for (int row = 0; row < m; row++)
                {
                    // collected by going to the cell on the right (->)
                    int right = (col == n - 1) ? 0 : bananaTable[row, col + 1];

                    // collected by going to the cell to right up (/)
                    int rightUp = (row == 0 || col == n - 1) ? 0 : bananaTable[row - 1, col + 1];

                    // collected by going to the cell to right down (\)
                    int rightDown = (row == m - 1 || col == n - 1) ? 0 : bananaTable[row + 1, col + 1];

                    // Max banana collected from taking either of the 3 paths
                    bananaTable[row, col] = matrix[row, col] + Math.Max(right, Math.Max(rightUp, rightDown));
                }
            }

            Console.WriteLine("--------Calculated Matrix--------");
            Console.WriteLine();
            PrintArray(bananaTable);
            Console.WriteLine();

            // The max amount of banana will be the max value in first column of all rows
            int maxBananas = 0;
            for (int i = 1; i < m; i++)
                maxBananas = Math.Max(maxBananas, bananaTable[i, 0]);

            return maxBananas;
        }

        /// <summary>
        /// Print array passed by parameter
        /// </summary>
        /// <param name="matrix">any Matrix </param>
        public void PrintArray(int[,] matrix)
        {
            if (matrix == null) return;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "\t");

                Console.WriteLine();
            }
        }
    }
}
