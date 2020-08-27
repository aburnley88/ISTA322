using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
                    Console.WriteLine("\nWelcome to Arnold's 'Guess My Number' Game!\n");
                    Console.WriteLine("There are 2 versions of 'Guess My Number'.\n\nIn version 1 the computer guesses your number.\n\nVersion 2 you guess the computers number.\n");
                    Console.WriteLine("Please enter number 1 to play version 1 or 2 for version 2.");
                    string userResponse = Console.ReadLine();

                    if (userResponse != "1" && userResponse != "2") { 
                        throw new FormatException();
                }
                    else
                    {
                        switch(userResponse)
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
            bool temp = true;
            Console.WriteLine("\nVersion 1:\n\nThere are 3 levels.\n");
            Console.WriteLine("Level 1 the computer gets 4 guesses to choose your number which can range from 1-10.");
            Console.WriteLine("Level 2 the computer gets 7 guesses and your number range increases to 100.");
            Console.WriteLine("Level 3 the computer gets 10 guesses and your number range increases to 1000.");
            do
            {
                try
                {
                    Console.WriteLine("Which level would you like to play?");
                    string userResponse = Console.ReadLine();
                    if (userResponse != "1" && userResponse != "2" && userResponse != "3")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        switch(userResponse)
                        {
                            case "1":
                            temp = false;
                            VersionOneLvlOneFirstGuess();
                                break;
                            case "2":
                                temp = false;
                                VersionOneLvlTwoFirstGuess();
                                break;
                            case "3":
                                temp = false;
                                VersionOneLvl3FirstGuess();
                                break;
                        }
                    }

                }
                catch (FormatException Fex)
                {

                    Console.WriteLine(Fex.Message + "\n");
                }

            } while (temp);
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
            Console.WriteLine($"\nMy guess is {guess} I have {chances - 1} more chances");
            VersionOneLvlOneGuess();
        }

        private void VersionOneLvlTwoFirstGuess()
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
            VersionOneLvl3Guess();
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
                    if (chances == 0)
                        PlayAgain();

                    Console.WriteLine($"\nPlease enter '>' for too high, '<' for too low, and '=' for just right!");
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
                                Console.WriteLine("\nI figured it out!");
                                PlayAgain();
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
                    if (chances == 0)
                        PlayAgain();

                    Console.WriteLine($"\nPlease enter '>' for too high, '<' for too low, and '=' for just right!");
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
                                Console.WriteLine("\nI figured it out!");
                                PlayAgain();
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

        private void VersionOneLvl3Guess()
        {
            int min = 1;
            int max = 1000;
            int chances = 9;
            int guess = 500;

            do
            {
                try
                {
                   

                    Console.WriteLine($"\nPlease enter '>' for too high, '<' for too low, and '=' for just right!");
                    string userResponse = Console.ReadLine();                   

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
                                Console.WriteLine("\nI figured it out!");
                                PlayAgain();
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
            bool temp = true;
            Console.WriteLine("\nVersion 2:\n\nThere are 3 levels.\n");
            Console.WriteLine("Level 1 the you get 4 guesses to determine the computers number which can range from 1 - 10.");
            Console.WriteLine("Level 2 the you get 7 guesses and the number range increases to 100.");
            Console.WriteLine("Level 3 you get 10 guesses and your number range increases to 1000.");
          
            do
            {
                try
                {
                    Console.WriteLine("Which level would you like to play?");
                    string userResponse = Console.ReadLine();
                    if (userResponse != "1" && userResponse != "2" && userResponse != "3")
                    {
                        throw new FormatException();
                    }
                    else
                    {
                        switch (userResponse)
                        {
                            case "1":
                                temp = false;
                                VersionTwoLvl1Guess();
                                break;
                            case "2":
                                temp = false;
                                VersionTwoLvl2Guess();
                                break;
                            case "3":
                                temp = false;
                                VersionTwoLvl3FirstGuess();
                                break;
                        }
                    }

                }
                catch (FormatException Fex)
                {

                    Console.WriteLine(Fex.Message + "\n");
                }

            } while (temp);
         
        }
        public void VersionTwoLvl1Guess()
        {
            Random r = new Random();
            int min = 1;
            int chances = 4;
            int max = 10;
            int num = r.Next(min, max);
            do
            {
                try
                {
                    if (chances == 0)
                        PlayAgain();

                    Console.WriteLine($"You have {chances} chances to guess my number.");
                    Console.WriteLine($"Please enter a number in this range {min} - {max}");
                    string userGuess = Console.ReadLine();
                    int userResponse = Int32.Parse(userGuess);
                    if (userResponse < min && userResponse > max)
                    {
                        throw new FormatException();
                    }
                    if (userResponse < num)
                    {
                        chances--;
                        min = userResponse + 1;
                    }
                    if (userResponse > num)
                    {
                        chances--;
                        max = userResponse - 1;
                    }
                    if (userResponse == num)
                    {
                        Console.WriteLine("You got it!");
                        chances = 0;
                        PlayAgain();
                    }

                }
                catch (FormatException fex)
                {

                    Console.WriteLine(fex.Message + "\n");
                }

            } while (chances > 0);
        }
        private void VersionTwoLvl2Guess()
        {

            Random r = new Random();
            int min = 1;
            int chances = 7;
            int max = 100;
            int num = r.Next(min, max);
            do
            {
                try
                {
                    if (chances == 0)
                        PlayAgain();

                        
                    Console.WriteLine($"You have {chances} chances to guess my number.");
                    Console.WriteLine($"Please enter a number in this range {min} - {max}");
                    string userGuess = Console.ReadLine();
                    int userResponse = Int32.Parse(userGuess);
                    if (userResponse < min && userResponse > max)
                    {
                        throw new FormatException();
                    }
                    if (userResponse < num)
                    {
                        chances--;
                        min = userResponse + 1;
                    }
                    if (userResponse > num)
                    {
                        chances--;
                        max = userResponse - 1;
                    }
                    if (userResponse == num)
                    {
                        Console.WriteLine("You got it!");
                        chances = 0;
                        PlayAgain();
                    }

                }
                catch (FormatException fex)
                {

                    Console.WriteLine(fex.Message + "\n");
                }

            } while (chances > 0);
        }

        private void VersionTwoLvl3FirstGuess()
        {

            Random r = new Random();
            int min = 1;
            int chances = 10;
            int max = 1000;
            int num = r.Next(min, max);
            do
            {
                try
                {
                    if (chances == 0)
                        PlayAgain();

                    Console.WriteLine($"You have {chances} chances to guess my number.");
                    Console.WriteLine($"Please enter a number in this range {min} - {max}");
                    string userGuess = Console.ReadLine();
                    int userResponse = Int32.Parse(userGuess);
                    if (userResponse < min && userResponse > max)
                    {
                        throw new FormatException();
                    }
                    if (userResponse < num)
                    {
                        chances--;
                        min = userResponse + 1;
                    }
                    if (userResponse > num)
                    {
                        chances--;
                        max = userResponse - 1;
                    }
                    if (userResponse == num)
                    {
                        Console.WriteLine("You got it!");
                        chances = 0;
                        PlayAgain();
                    }

                }
                catch (FormatException fex)
                {

                    Console.WriteLine(fex.Message + "\n");
                }

            } while (chances > 0);
        }
        public void PlayAgain()
        {
            bool temp = true;
            do
            {
                try
                {
                    
                    Console.WriteLine("Would you like to play again?" + "\nenter 0 for yes and 1 for no");
                    string userResponse = Console.ReadLine();
                    if (userResponse != "0" && userResponse != "1")
                    {
                        throw new FormatException();
                    }
                    else
                        temp = false;
                        Welcome();
                }
                catch (FormatException fex)
                {

                    Console.WriteLine(fex.Message + "\n");
                }

            } while (temp);

        }
   
    }
   
}
