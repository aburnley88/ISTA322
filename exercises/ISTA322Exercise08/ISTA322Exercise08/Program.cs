using System;

namespace ISTA322Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            GuessMyNumberGame game = new GuessMyNumberGame();
            game.Welcome();
        }
        
    }
       
    
}
