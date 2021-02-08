using System;
using System.Collections.Generic;
using System.Linq;

namespace Book_Worm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var initial = Console.ReadLine();
            var size = int.Parse(Console.ReadLine());

          
            char[,] matrix = GetMatrixSize(size);
            var rowP = 0;
            var colP = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        rowP = row;
                        colP = col;
                    }
                }
            }

            string command;
            bool isOut = false;
            
            while ((command = Console.ReadLine()) != "end")
            {
                var currentLetter = string.Empty;
                switch (command)
                {
                    case "up":

                        if (CellIsValid(matrix, rowP - 1, colP))
                        {
                            rowP--;
                            matrix[rowP + 1, colP] = '-';
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    case "down":
                        if (CellIsValid(matrix, rowP + 1, colP)) 
                        {
                            rowP++;
                            matrix[rowP - 1, colP] = '-';
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    case "right":
                        if (CellIsValid(matrix, rowP, colP + 1)) 
                        {
                            colP++;
                            matrix[rowP, colP - 1] = '-';
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                    case "left":
                        if (CellIsValid(matrix, rowP, colP - 1)) 
                        {
                            colP--;
                            matrix[rowP, colP + 1] = '-';
                        }
                        else
                        {
                            isOut = true;
                        }
                        break;
                }
                char currentIndex = matrix[rowP, colP];

                if (char.IsLetter(currentIndex) && currentIndex != 'P')
                {
                    initial += currentIndex;
                    matrix[rowP, colP] = 'P';
                }
                if (isOut==true)
                {
                    initial=initial.Remove(initial.Length - 1);
                }
                
               
            }
            Console.WriteLine(initial);
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        private static bool CellIsValid(char[,] matrix, int row, int col)
        {
            if (row>=0 && row<=matrix.GetLength(0)-1
                && col>=0 && col<=matrix.GetLength(1)-1)
            {
                return true;
            }
            return false;
        }

        private static Dictionary<int,int> GetPlayerPosition(char[,] matrix, char player)
        {
            var playerPosition =new Dictionary<int, int>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]==player)
                    {
                        playerPosition.Add(row, col);
                    }
                }
            }
            return playerPosition;
        }

        private static char[,] GetMatrixSize(int size)
        {
            var matrix = new char[size,size];

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

