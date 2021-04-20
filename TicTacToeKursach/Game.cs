using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeKursach
{
    class Game
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public Field Field { get; private set; }

        public Game((int fieldHeight, int fieldWidth) size, 
            char player1TextRepresentation, char player2TextRepresentation)
        {
            Field = new Field(size);
            Player1 = new Player(player1TextRepresentation);
            Player2 = new Player(player2TextRepresentation);
        }
    }
}
