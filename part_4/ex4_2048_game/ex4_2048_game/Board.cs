using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex4_2048_game;

namespace ex4_2048_game
{ 
    class Board
    {
        public int[,] Data { get; protected set; }

        public const int BOARD_SIZE = 4;
        public const int FIRST_VALUES = 2;

        public const int LEFT = 0;
        public const int RIGHT = 1;
        public const int UP = 2;
        public const int DOWN = 3;

        public MoveCell moveCell = new MoveCell();

        public void SetFirstRandomValues()
        {
            int indexRow;
            int indexCol;
            int value;

            Random randomIndex = new Random();
            Random randomNumber = new Random();

            int[,] data = new int[BOARD_SIZE, BOARD_SIZE];
            Data = data;

            for (int i = 0; i < FIRST_VALUES; i++)
            {
                value = randomNumber.Next(2, 5);
                while (value % 2 != 0)
                {
                    value = randomNumber.Next(2, 5);
                }

                indexRow = randomIndex.Next(0, BOARD_SIZE);
                indexCol = randomIndex.Next(0, BOARD_SIZE);

                Data[indexRow, indexCol] = value;
            }

            //temp
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Console.Write($"{Data[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public void Move(Diraction diraction)
        {
            switch (diraction)
            {
                case LEFT:
                    moveCell.MoveLeft();
                    break;

                case (Diraction)RIGHT:
                    moveCell.MoveRight();
                    break;

                case (Diraction)UP:
                    moveCell.MoveUp();
                    break;

                case (Diraction)DOWN:
                    moveCell.MoveDown();
                    break;
            }
        }
    }
}
