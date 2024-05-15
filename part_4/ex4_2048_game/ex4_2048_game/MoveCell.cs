using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2048_game
{
    class MoveCell: Board
    {
        public MoveCell(int[,] data) : base(data)
        {
            
        }
        public void MoveRight()// DONE
        {
            int tempIndex;

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        tempIndex = i;
                        for(int x = 0; x < BOARD_SIZE; x++)
                        {
                            if (tempIndex + 1 < BOARD_SIZE)
                            {
                                if (Data[i + 1, j] == Data[i, j])
                                {
                                    Data[i + 1, j] += Data[i, j];
                                    break;
                                }
                                else
                                {
                                    Data[i + 1, j] = Data[i, j];
                                    tempIndex++;
                                }
                                
                            }
                            else 
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void MoveLeft() //DONE
        {
            int tempIndex;

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        tempIndex = i;

                        for(int x = 0; x < BOARD_SIZE; x++)
                        {
                            if (tempIndex - 1 >= 0)
                            {
                                if (Data[i - 1, j] == Data[i, j])
                                {
                                    Data[i - 1, j] += Data[i, j];
                                    break;
                                }
                                else
                                {
                                    Data[i - 1, j] = Data[i, j];
                                    tempIndex--;
                                }
                                
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void MoveUp()
        {
            int tempIndex;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        tempIndex = j;
                        for (int x = 0; x < BOARD_SIZE; x++)
                        {
                            if (tempIndex - 1 >= 0)
                            {
                                if (Data[i, j - 1] == Data[i, j])
                                {
                                    Data[i, j - 1] += Data[i, j];
                                    break;
                                }
                                else 
                                {
                                    Data[i, j - 1] = Data[i, j];
                                    tempIndex--;
                                }
                                
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for(int j = 0; j<BOARD_SIZE; j++)
                {
                    Console.Write($"{Data[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void MoveDown()
        {
            int tempIndex;

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        tempIndex = j;
                        for (int x = 0; x < BOARD_SIZE; x++)
                        {
                            if (tempIndex + 1 < BOARD_SIZE)
                            {
                                Data[i, j + 1] = Data[i, j];
                                tempIndex++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
