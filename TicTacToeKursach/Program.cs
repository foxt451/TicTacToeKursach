using System;

namespace TicTacToeKursach
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game((5, 5), 'X', 'O');
            Graphics graphics = new Graphics();
            graphics.OutputGame(game);
        }
    }
}
