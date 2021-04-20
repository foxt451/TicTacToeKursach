using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeKursach
{
    class Player
    {
        public char TextRepresentation { get; private set; }

        public Player(char textRepresentation)
        {
            TextRepresentation = textRepresentation;
        }
    }
}
