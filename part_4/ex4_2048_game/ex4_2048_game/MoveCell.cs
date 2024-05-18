using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex4_2048_game;

namespace ex4_2048_game
{
    class MoveCell: Board
    {
        public const int DEFAULT_VALUE = -9999;
        
        public MoveCell(int[,] data) : base(data)
        {

        }

        public int[,] MoveRight()
        {
            int tempIndex;
            for (int row = 0; row < BOARD_SIZE; row++)
            {
                for (int col = 0; col < BOARD_SIZE; col++)
                {
                    tempIndex = 1;
                    while (col - tempIndex >= col)
                    {
                        if (Data[row + tempIndex, col] == 0)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex + 1, col] = 0;
                        }
                        else if (Data[row + tempIndex, col] == Data[row, col])
                        {
                            Data[row + tempIndex, col] = Data[row, col] + Data[row, col];
                            Data[row + tempIndex + 1, col] = 0;

                            if (col != 0)
                            {
                                Data[row + tempIndex + 1, col] = DEFAULT_VALUE;
                            }
                            break;
                        }
                        else if (Data[row + tempIndex + 1, col] == DEFAULT_VALUE)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex + 1, col] = 0;
                            break;
                        }
                        break;
                    }
                }
            }
            Data = AddTwoRandomValues();
            return Data;
        }

        public int[,] MoveLeft()
        {
            int tempIndex;
            for (int row = 0; row < BOARD_SIZE - 1; row++) 
            {
                for (int col = 0; col < BOARD_SIZE; col++)
                {
                    tempIndex = 1;
                    while (tempIndex + col <= col)
                    {
                        if (Data[row + tempIndex, col] == 0)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex - 1, col] = 0;
                        }
                        else if (Data[row + tempIndex, col] == Data[row, col])
                        {
                            Data[row + tempIndex, col] = Data[row, col] + Data[row, col];
                            Data[row + tempIndex - 1, col] = 0;

                            if (col != 0)
                            {
                                Data[row + tempIndex - 1, col] = DEFAULT_VALUE;
                            }
                            break;
                        }
                        else if (Data[row + tempIndex - 1, col] == DEFAULT_VALUE)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex - 1, col] = 0;
                            break;
                        }
                        break;
                    }
                }
            }
            Data = AddTwoRandomValues();
            return Data;
        }

        public int[,] MoveUp()
        {
            int tempIndex;
            for (int row = 0; row < BOARD_SIZE; row++) 
            {
                for (int col = 0; col < BOARD_SIZE; col++)
                {
                    tempIndex = 1;
                    while (col - tempIndex >= col)
                    {
                        if (Data[row + tempIndex, col] == 0)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex, col + 1] = 0;
                        }
                        else if (Data[row + tempIndex, col] == Data[row, col])
                        {
                            Data[row + tempIndex, col] = Data[row, col] + Data[row, col];
                            Data[row + tempIndex, col + 1] = 0;

                            if (col != 0)
                            {
                                Data[row + tempIndex, col + 1] = DEFAULT_VALUE;
                            }
                            break;
                        }
                        else if (Data[row + tempIndex, col + 1] == DEFAULT_VALUE)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex, col + 1] = 0;
                            break;
                        }
                        break;
                    }
                }
            }
            Data = AddTwoRandomValues();
            return Data;
        }

        public int[,] MoveDown()
        {
            int tempIndex;
            for (int row = 0; row < BOARD_SIZE; row++)
            {
                for (int col = BOARD_SIZE - 1; col >= 0; col--)
                {
                    tempIndex = 1;
                    while (tempIndex + col <= col)
                    {
                        if (Data[row + tempIndex, col] == 0)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex, col - 1] = 0;
                        }
                        else if (Data[row + tempIndex, col] == Data[row, col])
                        {
                            Data[row + tempIndex, col] = Data[row, col] + Data[row, col];
                            Data[row + tempIndex, col - 1] = 0;

                            if (col != 0)
                            {
                                Data[row + tempIndex, col - 1] = DEFAULT_VALUE;
                            }
                            break;
                        }
                        else if (Data[row + tempIndex, col - 1] == DEFAULT_VALUE)
                        {
                            Data[row + tempIndex, col] = Data[row, col];
                            Data[row + tempIndex, col - 1] = 0;
                            break;
                        }
                        break;
                    }
                }
            }
            Data = AddTwoRandomValues();
            return Data;
        }

        public int[,] AddTwoRandomValues()
        {
            int indexRow;
            int indexCol;
            int value;

            Random randomIndex = new Random();
            Random randomNumber = new Random();

            for (int i = 0; i < FIRST_VALUES; i++)
            {
                value = randomNumber.Next(2, BOARD_SIZE + 1);
                while (value % 2 != 0)
                {
                    value = randomNumber.Next(2, BOARD_SIZE + 1);
                }

                indexRow = randomIndex.Next(0, BOARD_SIZE);
                indexCol = randomIndex.Next(0, BOARD_SIZE);

                if (Data[indexRow, indexCol] != 0)
                {
                    indexRow = randomIndex.Next(0, BOARD_SIZE);
                    indexCol = randomIndex.Next(0, BOARD_SIZE);
                }
                Data[indexRow, indexCol] = value;
            }
            return Data;
        }
    }
}
