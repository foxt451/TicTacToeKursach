using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeKursach
{
    class Graphics
    {
        public void OutputGame(Game game)
        {
            OutputField(game.Field.Matrix, game.Player1.TextRepresentation, game.Player2.TextRepresentation);
        }

        private void OutputField(int[,] field, 
            char player1TextRepresentation, char player2TextRepresentation)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                if (i != 0)
                {
                    // output row separator
                    for (int j = 0; j < field.GetLength(1); j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("-");
                        } 
                        else
                        {
                            Console.Write("--");
                        }
                    }
                    Console.WriteLine();
                }
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 1)
                    {
                        Console.Write(player1TextRepresentation);
                    }
                    else if (field[i, j] == 2)
                    {
                        Console.Write(player2TextRepresentation);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    if (j != field.GetLength(1) - 1)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
