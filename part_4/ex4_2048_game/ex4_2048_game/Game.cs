using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_2048_game
{
    class Game
    {
        public Board board { get; private set; }
        public GameStatus gameStatus { get; private set; }
    }
}
