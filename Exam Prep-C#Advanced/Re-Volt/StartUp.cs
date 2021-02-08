using System;

namespace Re_Volt
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = GetMatrix(matrixSize);
            var playerRow = 0;
            var playerCol = 0;
            bool EndFound = false;
            for (int row= 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1);col++)
                {
                    if (matrix[row,col]=='f')
                    {
                        playerRow = row;
                        playerCol = row;
                        break;
                    }
                }
            }

            while (commandsCount!=0)
            {
                var command = Console.ReadLine();
                matrix[playerRow, playerCol] = '-';
                switch (command)
                {
                    case "up":
                         playerRow--;
                        if (playerRow<0)
                        {
                            playerRow = matrix.GetLength(0)-1;
                        }
                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow--;
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow--;
                        }
                        if (playerRow < 0)
                        {
                            playerRow = matrix.GetLength(0)-1;
                        }
                        if (matrix[playerRow,playerCol]=='F')
                        {
                            EndFound = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    case "down":
                        playerRow++;
                        if (playerRow > matrix.GetLength(0))
                        {
                            playerRow = 0;
                        }
                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow--;
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerRow++;
                        }
                        if (playerRow > matrix.GetLength(0))
                        {
                            playerRow = 0;
                        }
                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            EndFound = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    case "left":
                        playerCol--;
                        if (playerCol < 0)
                        {
                            playerCol = matrix.GetLength(1)-1;
                        }
                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol--;
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol--;
                        }
                        if (playerCol < 0)
                        {
                            playerCol = matrix.GetLength(1) - 1;
                        }
                        if (playerCol < 0)
                        {
                            playerCol = matrix.GetLength(1)-1;
                        }
                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            EndFound = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                        break;
                    case "right":
                        playerCol++;
                        if (playerCol>matrix.GetLength(1))
                        {
                            playerCol = 0;
                        }
                        if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol--;
                        }
                        else if (matrix[playerRow, playerCol] == 'B')
                        {
                            playerCol++;
                        }
                        if (playerCol > matrix.GetLength(1))
                        {
                            playerCol = 0;
                        }
                        if (matrix[playerRow, playerCol] == 'F')
                        {
                            EndFound = true;
                        }
                        matrix[playerRow, playerCol] = 'f';
                        break;
                }
                if (EndFound)
                {
                    break;
                }
                commandsCount--;
            }
            if (EndFound)
            {
                Console.WriteLine($"Player won!");
            }
            else
            {
                Console.WriteLine($"Player lost!");
            }
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }

        private static char[,] GetMatrix(int size)
        {
            var matrix = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine();
                for (int k = 0; k < input.Length; k++)
                {
                    matrix[i, k] = input[k];
                }
            }
            return matrix;
        }
    }
}
