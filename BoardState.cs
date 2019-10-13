using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class BoardState
    {
        private string One; //open, X, O
        private string Two;
        private string Three;
        private string Four;
        private string Five;
        private string Six;
        private string Seven;
        private string Eight;
        private string Nine; 

        public BoardState() // Fix the casing on the below methods
        {
            this.One = "open";
            this.Two = "open";
            this.Three = "open";
            this.Four = "open";
            this.Five = "open";
            this.Six = "open";
            this.Seven = "open";
            this.Eight = "open";
            this.Nine = "open";
        }

        public void updateBoardState(int cellNumber, string currentPlayer) //updates the board state
        {
            string CurrentPlayer = currentPlayer;

            //string player = Game.player;
            //string CellToString = "";
            switch (cellNumber)
            {
                case 1:
                    SetOne(CurrentPlayer);
                    break;

                case 2:
                    SetTwo(CurrentPlayer);
                    break;

                case 3:
                    SetThree(CurrentPlayer);
                    break;

                case 4:
                    SetFour(CurrentPlayer);
                    break;

                case 5:
                    SetFive(CurrentPlayer);
                    break;

                case 6:
                    SetSix(CurrentPlayer);
                    break;

                case 7:
                    SetSeven(CurrentPlayer);
                    break;

                case 8:
                    SetEight(CurrentPlayer);
                    break;

                case 9:
                    SetNine(CurrentPlayer);
                    break;
            }
        }
        public string GetOne() 
        {
            return One;
        }

        public void SetOne(string CurrentPlayer) //USE THIS TO CHECK IF THERE IS ANYTHING THERE FIRST!!!!!!!!!!!!!!!!!!
        {
            //(String.Equals(this.One, "open", StringComparison.OrdinalIgnoreCase)) is a standard way to do string comparison like below
            if (this.One == "open")
            {
                this.One = CurrentPlayer;
            } 
            else 
            { 
                Console.Clear(); 
            }
        }

        public string GetTwo()
        {
            return Two;
        }

        public void SetTwo(string CurrentPlayer)
        {
            Two = CurrentPlayer;
        }

        public string GetThree()
        {
            return Three;
        }

        public void SetThree(string CurrentPlayer)
        {
            Three = CurrentPlayer;
        }

        public string GetFour()
        {
            return Four;
        }

        public void SetFour(string CurrentPlayer)
        {
            Four = CurrentPlayer;
        }

        public string GetFive()
        {
            return Five;
        }

        public void SetFive(string CurrentPlayer)
        {
            Five = CurrentPlayer;
        }

        public string GetSix()
        {
            return Six;
        }

        public void SetSix(string CurrentPlayer)
        {
            Six = CurrentPlayer;
        }

        public string GetSeven()
        {
            return Seven;
        }

        public void SetSeven(string CurrentPlayer)
        {
            Seven = CurrentPlayer;
        }

        public string GetEight()
        {
            return Eight;
        }

        public void SetEight(string CurrentPlayer)
        {
            Eight = CurrentPlayer;
        }

        public string GetNine()
        {
            return Nine;
        }

        public void SetNine(string CurrentPlayer)
        {
            Nine = CurrentPlayer;
        }

        public string WinChecker()
        {
            if (
                this.One == "X" && this.Two == "X" && this.Three == "X" ||
                this.Four == "X" && this.Five == "X" && this.Six == "X" ||
                this.Seven == "X" && this.Eight == "X" && this.Nine == "X" ||
                this.One == "X" && this.Four == "X" && this.Seven == "X" ||
                this.Two == "X" && this.Five == "X" && this.Eight == "X" ||
                this.Three == "X" && this.Six == "X" && this.Nine == "X" ||
                this.One == "X" && this.Five == "X" && this.Nine == "X" ||
                this.Three == "X" && this.Five == "X" && this.Seven == "X"
               )
            {
                return "X is the winner";
            }
            if (
                this.One == "O" && this.Two == "O" && this.Three == "O" ||
                this.Four == "O" && this.Five == "O" && this.Six == "O" ||
                this.Seven == "O" && this.Eight == "O" && this.Nine == "O" ||
                this.One == "O" && this.Four == "O" && this.Seven == "O" ||
                this.Two == "O" && this.Five == "O" && this.Eight == "O" ||
                this.Three == "O" && this.Six == "O" && this.Nine == "O" ||
                this.One == "O" && this.Five == "O" && this.Nine == "O" ||
                this.Three == "O" && this.Five == "O" && this.Seven == "O"
               )
            {
                return "O is the winner";
            }

            return "";
        }
    }
}
