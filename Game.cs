using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class Game
    {
        bool playerState = true;
        string CurrentPlayer;
        int gameTurn = 1;
        bool winner;
        bool active = true;

        public Game()
        {
            Board board = new Board();
            BoardState boardState = new BoardState();
            while (active)
            {
                //PlaceAt("", 0, 4);
                Console.WriteLine("Input desired marker position: ");
                string PlayerInput = Console.ReadLine();
                int Cell;
                bool ValidInput = int.TryParse(PlayerInput, out Cell);
                if (ValidInput == true)
                {
                    boardState.updateBoardState(Cell, CurrentPlayer);   //attempts to set X and O position in boardState instance
                    Console.WriteLine(boardState.GetOne());     //checking if boardState updated when 1 was input
                    PlaceMarker(Cell);
                    string IsThereAWinner = boardState.WinChecker();
                    PlaceAt("", 0, 5);
                    Console.WriteLine(IsThereAWinner);
                    if (playerState == true) playerState = false;
                    else playerState = true;
                }
                else
                {
                    PlaceAt("", 0, 5);
                    Console.WriteLine("Not a valid input, please input a valid cell number:");
                }

                
            }
        }
        
        protected static int origRow;
        protected static int origCol;

        protected static void PlaceAt(string s, int x, int y) //Places marker at, string s, position (x, y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }


        public void PlaceMarker(int cell) //Places player marker in selected square
        {
            if (playerState) CurrentPlayer = "X";
            else CurrentPlayer = "O";
            switch (cell)
            {
                case 1:
                    PlaceAt(CurrentPlayer, 1, 0);
                    break;

                case 2:
                    PlaceAt(CurrentPlayer, 5, 0);
                    break;

                case 3:
                    PlaceAt(CurrentPlayer, 9, 0);
                    break;

                case 4:
                    PlaceAt(CurrentPlayer, 1, 2);
                    break;

                case 5:
                    PlaceAt(CurrentPlayer, 5, 2);
                    break;

                case 6:
                    PlaceAt(CurrentPlayer, 9, 2);
                    break;

                case 7:
                    PlaceAt(CurrentPlayer, 1, 4);
                    break;

                case 8:
                    PlaceAt(CurrentPlayer, 5, 4);
                    break;

                case 9:
                    PlaceAt(CurrentPlayer, 9, 4);
                    break;
            }
        }
    }
}
