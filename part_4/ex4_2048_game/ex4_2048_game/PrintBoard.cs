using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex4_2048_game;

namespace ex4_2048_game
{
    class PrintBoard: MoveCell
    {
        public PrintBoard(int[,] data) : base(data)
        {

        }
        public void PrintBoardToScreen()
        {
            Console.WriteLine();
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Console.Write($"{Data[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
