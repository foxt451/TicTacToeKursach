using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeKursach
{
    class Field
    {
        private (int height, int width) size;

        public int[,] Matrix { get; private set; } // 2d field with moves, 1 - one player, 2 - another, 0 - empty cell

        public Field(int height, int width)
        {
            size = (height, width);
            Matrix = new int[height, width];
        }

        public Field((int height, int width) size) : this(size.height, size.width)
        {
        }
    }
}
