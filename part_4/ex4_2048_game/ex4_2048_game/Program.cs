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
            Board board = new Board(data);
            Diraction diraction = Diraction.Up;
            board.Move(diraction);
        }
    }
}
