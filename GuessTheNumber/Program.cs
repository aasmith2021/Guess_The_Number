using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the GUESS THE NUMBER GAME!!! \r\n\r\nPlease enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Welcome, {userName}!\r\n\r\nIn this game, our AMAZING COMPUTER is going to pick a pseudo-random number between 1 and 100.\r\n\r\nOnce the computer picks a number, you'll get 5 guesses to try and match the number the computer picked. If you guess the number in those 5 tries, YOU WIN! But, if you don't, you'll lose. Good luck!!!");

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("\r\n\r\nPress \"Enter\" to tell the computer to select a number...");

                Console.ReadLine();
                Random randomNumber = new Random();
                int computerNumber = randomNumber.Next(1, 101);
                int guessCount = 5;
                string userGuess = "";
                string outputMessage = "";
                int userGuessInt = 0;
                string winningMessage = "You guessed correctly! You win!!!";

                Console.WriteLine("The computer is thinking...thinking...thinking...Got it! The computer has selected a number!\r\n\r\nWhat is your first guess? Enter the number and press \"Enter\".");

                while (guessCount > 0)
                {
                    if (guessCount > 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"You have {guessCount} guesses left.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"You have {guessCount} guess left.");
                    }
                    userGuess = Console.ReadLine();
                    userGuessInt = Int32.Parse(userGuess);

                    if (guessCount > 1)
                    {
                        outputMessage = (userGuessInt == computerNumber) ?
                          winningMessage :
                            (userGuessInt > computerNumber) ?
                            "You guessed TOO HIGH. Guess again!" :
                            "You guessed TOO LOW. Guess again!";
                    }
                    else
                    {
                        outputMessage = (userGuessInt == computerNumber) ?
                        winningMessage :
                          (userGuessInt > computerNumber) ?
                          "You guessed TOO HIGH." :
                          "You guessed TOO LOW.";
                    }

                    if (outputMessage == winningMessage)
                    {
                        guessCount = 0;
                    }

                    Console.WriteLine(outputMessage);
                    guessCount--;
                }

                if (outputMessage != winningMessage)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Sorry! You ran out of guesses! The number was {computerNumber}. Better luck next time!");
                }

                Console.WriteLine("\r\nDo you want to play again? Enter Y for \"Yes\" and N for \"No\".");
                string playAgainString = "";

                while (playAgainString != "N" && playAgainString != "Y")
                {
                    playAgainString = Console.ReadLine().ToUpper();
                    
                    if (playAgainString == "N")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry. Please enter Y for \"Yes\" and N for \"No\".");
                    }
                }

            }
            Console.WriteLine("\r\nThank you for playing! Have a great day!");
            Console.WriteLine();
            Console.WriteLine("Press \"Enter\" to exit the game.");
            Console.ReadLine();
        }
    }
}

