using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2048_game
{
    class Game
    {
        public Board Board { get; set; }
        public GameStatus GameStatus { get; set; }
        public int Point { get; protected set; }
    }
}
