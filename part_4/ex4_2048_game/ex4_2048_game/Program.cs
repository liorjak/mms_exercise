using System;
using ex4_2048_game;

namespace ex4_2048_game
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BOARD_SIZE = 4;

            int[,] data = new int[BOARD_SIZE, BOARD_SIZE];
            int diraction;

            Board board = new Board(data);
            Menu menu = new Menu();
            PrintBoard print = new PrintBoard(data);

            for (int row = 0; row < BOARD_SIZE; row++)
            {
                for (int col = 0; col < BOARD_SIZE; col++)
                {
                    while (data[row, col] != 2048)
                    {
                        Console.WriteLine();
                        diraction = menu.GetUserChoice();
                        board.Move(diraction);                  
                        print.PrintBoardToScreen();
                    }
                    break;
                }
            }
        }
    }
}
