using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ex4_2048_game;

namespace ex4_2048_game
{
    class Game
    {
        public Board Board { get; protected set; }
        public GameStatus GameStatus { get; protected set; }
        public int Point { get; protected set; }

        public void Move()
        {
            while(GameStatus != GameStatus.Lose) // ADD
            {
                
            }
        }
    }
}
