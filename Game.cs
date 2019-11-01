using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TicTacToeGame
{
    class Game
    {

        public Game()
        {
            int count = 0;
            string CurrentPlayer = "X";
            BoardState boardState = new BoardState();
            while (count < 9)
            {
                Console.Clear();
                boardState.DrawBoard();
                Console.WriteLine("Input desired marker position: ");
                Console.Write($"Player {CurrentPlayer}'s Turn: ");
                int Cell;
                bool ValidInput = int.TryParse(Console.ReadLine(), out Cell);   //checks for valid input (1-9 only) 
                if (ValidInput != true || Cell < 1 || Cell > 9)
                {
                    Console.Clear();
                    Console.WriteLine("Not a valid input, please select a cell number 1 - 9");
                    Console.ReadKey();
                    continue;
                }
                else if (boardState.HasMarker(Cell))                            //checks for marker at cell location
                    continue;
                else if (ValidInput == true)
                {
                    boardState.updateBoardState(Cell, CurrentPlayer);           //sets X and O position in boardState instance
                    if (boardState.WinChecker(CurrentPlayer) == true)
                    {
                        Console.Clear();
                        boardState.DrawBoard();
                        Console.WriteLine($"{CurrentPlayer} is the winner!!!!");
                        return;
                    }
                    count++;
                }

                if (CurrentPlayer == "X")
                {
                    CurrentPlayer = "O";
                }
                else CurrentPlayer = "X";
            }
            Console.Clear();
            boardState.DrawBoard();
            Console.WriteLine("The game is a draw");
        }
    }
}
