using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ISTA322Exercise08
{
    class GuessMyNumberGame
    {
        public void Welcome()
        {
            bool temp = true;
            do
            {
                try
                {
                    Console.WriteLine("Welcome to Arnold's 'Guess My Number' Game!\n");
                    Console.WriteLine("There are 2 versions of 'Guess My Number'.\n\nIn version 1 the computer guesses your number.\n\nVersion 2 you guess the computers number.\n");
                    Console.WriteLine("Please enter number 1 to play version 1 or 2 for version 2.");
                    string result = Console.ReadLine();

                    if (result != "1" && result != "2") { 
                        throw new FormatException();
                }
                    else
                    {
                        switch(result)
                        {
                            case "1":
                                temp = false;
                                Version1();
                                break;
                            case "2":
                                temp = false;
                                Version2();
                                break;
                        }
                    }                                                        
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message + "\n");
                }
               
            } while (temp);
        }
        public void Version1()
        {
            Console.WriteLine("\nVersion 1:\n\nThere are 3 levels.\n");
            Console.WriteLine("Level 1 the computer gets 4 guesses to choose your number which can range from 1-10.");
            Console.WriteLine("Level 2 the computer gets 7 guesses and your number range increases to 100.");
            Console.WriteLine("Level 3 the computer gets 10 guesses and your number range increases to 1000.");
            Console.WriteLine("Which level would you like to play?");
            
            string Result = Console.ReadLine();
            if (Result == "1")           
                VersionOneLvlOneFirstGuess();
            if (Result == "2")
                VersionOneLvl2FirstGuess();
            if (Result == "3")
                VersionOneLvl3FirstGuess();
            
        }

        private void VersionOneLvl3FirstGuess()
        {
            int min = 1;
            int max = 1000;
            int chances = 10;
            int guess = 0;

            Console.WriteLine("Welcome to level 3.");
            Console.WriteLine($"\nPlease mentally a number between {min} and {max}.");

            if (chances == 10)
                guess = max / 2;
            Console.WriteLine($"\nMy guess is {guess} I have {chances - 1} more chances");
            VersionOneLvlThreeGuess();
        }

        private void VersionOneLvlThreeGuess()
        {
            int min = 1;
            int max = 1000;
            int chances = 9;
            int guess = 500;

            do
            {
                try
                {
                    Console.WriteLine($"Please enter '>' for too high, '<' for too low, and '=' for just right!");
                    string userResponse = Console.ReadLine();
                    Random r = new Random();

                    if (userResponse != ">" && userResponse != "<" && userResponse != "=")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        switch (userResponse)
                        {
                            case ">":
                                max = guess - 1;
                                chances--;
                                guess = min + (max - min) / 2;
                                Console.WriteLine($"\nMy guess is {guess} I have {chances} chances");
                                break;
                            case "=":
                                chances = 0;
                                Console.WriteLine("I figured it out!");
                                break;
                            case "<":
                                min = guess + 1;
                                chances--;
                                guess = min + (max - min) / 2;
                                Console.WriteLine($"\nMy guess is {guess} I have {chances} chances");
                                break;
                        }
                    }
                }

                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message + "\n");
                }
            } while (chances > 0);
        }

        public void Version2()
        {
            Console.WriteLine("\nVersion 2:\n\nThere are 3 levels.\n");
            Console.WriteLine("Level 1 the you get 4 guesses to determine the computers number which can range from 1 - 10.");
            Console.WriteLine("Level 2 the you get 7 guesses and the number range increases to 100.");
            Console.WriteLine("Level 3 you get 10 guesses and your number range increases to 1000.");
            Console.WriteLine("Which level would you like to play?");
        }
        public void VersionOneLvlOneFirstGuess()
        {
            int min = 1;
            int max = 10;
            int chances = 4;
            int guess = 0;

            Console.WriteLine("Welcome to level 1.");
            Console.WriteLine($"\nPlease mentally a number between {min} and {max}.");
                       
                if (chances == 4)              
                     guess = max / 2;              
                Console.WriteLine($"\nMy guess is {guess} I have {chances-1} more chances");
            VersionOneLvlOneGuess();
        }

        public void VersionOneLvlOneGuess()
        {
            int min = 1;
            int max = 10;
            int chances = 3;
            int guess = 5;
                    
            do
            {
                try
                {
                    Console.WriteLine($"Please enter '>' for too high, '<' for too low, and '=' for just right!");
                    string userResponse = Console.ReadLine();
                    Random r = new Random();

                    if (userResponse != ">" && userResponse != "<" && userResponse != "=")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        switch (userResponse)
                        {
                            case ">":
                                max = guess - 1;
                                chances--;
                                guess = min + (max - min) / 2;
                                Console.WriteLine($"\nMy guess is {guess} I have {chances} chances");
                                break;
                            case "=":
                                chances = 0;
                                Console.WriteLine("I figured it out!");
                                break;
                            case "<":
                                min = guess + 1;
                                chances--;
                                guess = min + (max - min) / 2;
                                Console.WriteLine($"\nMy guess is {guess} I have {chances} chances");
                                break;
                        }
                    }
                }

                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message + "\n");
                }
            } while (chances > 0);
           
        }
        public void VersionOneLvl2FirstGuess()
        {
            int min = 1;
            int max = 100;
            int chances = 7;
            int guess = 0;

            Console.WriteLine("Welcome to level 2.");
            Console.WriteLine($"\nPlease mentally a number between {min} and {max}.");

            if (chances == 7)
                guess = max / 2;
            Console.WriteLine($"\nMy guess is {guess} I have {chances - 1} more chances");
            VersionOneLvl2Guess();
        }
        public void VersionOneLvl2Guess()
        {
            int min = 1;
            int max = 100;
            int chances = 7;
            int guess = 50;

            do
            {
                try
                {
                    Console.WriteLine($"Please enter '>' for too high, '<' for too low, and '=' for just right!");
                    string userResponse = Console.ReadLine();
                    Random r = new Random();

                    if (userResponse != ">" && userResponse != "<" && userResponse != "=")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        switch (userResponse)
                        {
                            case ">":
                                max = guess - 1;
                                chances--;
                                guess = min + (max - min) / 2;
                                Console.WriteLine($"\nMy guess is {guess} I have {chances} chances. {min} -{max}");
                                break;
                            case "=":
                                chances = 0;
                                Console.WriteLine("I figured it out!");
                                break;
                            case "<":
                                min = guess + 1;
                                chances--;
                                guess = min + (max - min) / 2;
                                Console.WriteLine($"\nMy guess is {guess} I have {chances} chances. {min}-{max}");
                                break;
                        }
                    }
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message + "\n");
                }
            } while (chances > 0);
            
        }
       
    } 
    //public void VersionTwoLvl1Guess()
    //{
    //    Random r = new Random();
    //    int min = 1;
    //    int chances = 4;
    //    int max = 10;
    //    int num = r.Next(min, max);
    //    Console.WriteLine($"You have {chances} to guess my number.");
    //    Console.WriteLine($"Please enter a number in this range {min} - {max}");
    //    string userGuess = Console.ReadLine();
    //}
}
