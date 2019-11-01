using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class BoardState
    {
        string[] BoardArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public void DrawBoard()
        {
            Console.WriteLine(" {0} | {1} | {2} ", BoardArray[0], BoardArray[1], BoardArray[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", BoardArray[3], BoardArray[4], BoardArray[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" {0} | {1} | {2} ", BoardArray[6], BoardArray[7], BoardArray[8]);
        }

        public bool HasMarker(int cellToCheck)
        {
            if (BoardArray[cellToCheck - 1] != cellToCheck.ToString() )
            {
                Console.Clear();
                Console.WriteLine("Position is already occupied. Please select another position.");
                Console.ReadKey();
                return true;
            }
            return false;
        }

        public void updateBoardState(int cellNumber, string currentPlayer) //updates the board state
        {
            string CurrentPlayer = currentPlayer;
            switch (cellNumber)
            {
                case 1:
                    BoardArray[0] = CurrentPlayer;
                    break;

                case 2:
                    BoardArray[1] = CurrentPlayer;
                    break;

                case 3:
                    BoardArray[2] = CurrentPlayer;
                    break;

                case 4:
                    BoardArray[3] = CurrentPlayer;
                    break;

                case 5:
                    BoardArray[4] = CurrentPlayer;
                    break;

                case 6:
                    BoardArray[5] = CurrentPlayer;
                    break;

                case 7:
                    BoardArray[6] = CurrentPlayer;
                    break;

                case 8:
                    BoardArray[7] = CurrentPlayer;
                    break;

                case 9:
                    BoardArray[8] = CurrentPlayer;
                    break;
            }
        }
        public bool WinChecker(string CurrentPlayer)
        {
            if (
                BoardArray[0] == CurrentPlayer && BoardArray[1] == CurrentPlayer && BoardArray[2] == CurrentPlayer ||
                BoardArray[3] == CurrentPlayer && BoardArray[4] == CurrentPlayer && BoardArray[5] == CurrentPlayer ||
                BoardArray[6] == CurrentPlayer && BoardArray[7] == CurrentPlayer && BoardArray[8] == CurrentPlayer ||
                BoardArray[0] == CurrentPlayer && BoardArray[3] == CurrentPlayer && BoardArray[6] == CurrentPlayer ||
                BoardArray[1] == CurrentPlayer && BoardArray[4] == CurrentPlayer && BoardArray[7] == CurrentPlayer ||
                BoardArray[2] == CurrentPlayer && BoardArray[5] == CurrentPlayer && BoardArray[8] == CurrentPlayer ||
                BoardArray[0] == CurrentPlayer && BoardArray[4] == CurrentPlayer && BoardArray[8] == CurrentPlayer ||
                BoardArray[2] == CurrentPlayer && BoardArray[4] == CurrentPlayer && BoardArray[6] == CurrentPlayer
               )
            {
                return true;
            }

            return false;
        }
    }
}
