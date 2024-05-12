using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2048_game
{
    class MoveCell: Board
    {
        

        private void MoveRight()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        if (i + 1 < BOARD_SIZE)
                        {
                            Data[i + 1, j] = Data[i, j];
                        }
                    }
                }
            }
        }

        public void MoveLeft()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        if (i - 1 >= 0)
                        {
                            Data[i - 1, j] = Data[i, j];
                        }
                    }
                }
            }
        }

        public void MoveUp()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        if (j - 1 >= 0)
                        {
                            Data[i, j - 1] = Data[i, j];
                        }
                    }
                }
            }
        }

        public void MoveDown()
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (Data[i, j] != 0)
                    {
                        if (j + 1 < BOARD_SIZE)
                        {
                            Data[i, j + 1] = Data[i, j];
                        }
                    }
                }
            }
        }
    }
}
