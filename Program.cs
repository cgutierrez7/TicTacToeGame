using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                Console.WriteLine("Play Again? (y/n)");
                char quit;
                char.TryParse(Console.ReadLine(), out quit);
                quit = char.ToLower(quit);
                if (quit == 'y')
                    game = new Game();
                else if (quit == 'n')
                    return;
                else 
                    continue;
            }
        }
    }
}