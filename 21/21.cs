using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _21
{
    class _21
    {
        public virtual void Game21()
        {
            Random randomCard = new Random();
            string latestWinner = "No one have won yet!";

            Console.WriteLine("Welcome to the game \"21\"!");

            bool menuWhile = true;
            while (menuWhile)
            {
                Console.WriteLine();
                Console.WriteLine("Choose:");
                Console.WriteLine("1. Play 21");
                Console.WriteLine("2. Show last winner");
                Console.WriteLine("3. Show the rules of the game");
                Console.WriteLine("4. Close the program");
                Console.WriteLine();

                var menuNumber = Console.ReadKey();
                switch (menuNumber.Key)
                {
                    case ConsoleKey.D1:
                        int computerScore = 0;
                        int playerScore = 0;
                        Console.WriteLine();
                        Console.WriteLine("Now two cards will be deducted per player");
                        computerScore += randomCard.Next(1, 11);
                        computerScore += randomCard.Next(1, 11);
                        playerScore += randomCard.Next(1, 11);
                        playerScore += randomCard.Next(1, 11);

                        string cardChoose = " ";
                        while (cardChoose != "n" && playerScore <= 21)
                        {
                            Console.WriteLine($"Your score: {playerScore}");
                            Console.WriteLine($"Computer score: {computerScore}");
                            Console.WriteLine("Do you want another card? (y/n)");
                            cardChoose = Console.ReadLine();

                            switch (cardChoose)
                            {
                                case "y":
                                    int newPlayerScore = randomCard.Next(1, 11);
                                    playerScore += newPlayerScore;
                                    Console.WriteLine($"Your new card is: {newPlayerScore}");
                                    Console.WriteLine($"Your total score is: {playerScore}");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Try again!");
                                    break;
                            }
                        }

                        if (playerScore > 21)
                        {
                            Console.WriteLine("You got more than 21 points and have lost!");
                            break;
                        }

                        while (computerScore < playerScore && computerScore <= 21)
                        {
                            int newComputerScore = randomCard.Next(1, 11);
                            computerScore += newComputerScore;
                            Console.WriteLine($"Computer new card is: {newComputerScore}");
                        }

                        Console.WriteLine($"Your total score: {playerScore}");
                        Console.WriteLine($"Computer total score: {computerScore}");

                        if (computerScore > 21)
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine("Write your name:");
                            latestWinner = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Computer has won!");
                        }

                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine($"Latest winner: {latestWinner}");
                        Thread.Sleep(2000);
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("Your goal is to force your computer to get more than 21 points.");
                        Console.WriteLine("You score by drawing cards, each card has 1-10 points.");
                        Console.WriteLine("If you get more than 21 points you have lost.");
                        Console.WriteLine("Both you and the computer get two cards at the beginning.");
                        Console.WriteLine("Then you get more cards until you are satisfied or get over 21.");
                        Console.WriteLine("When done, the computer will draw cards until it has more");
                        Console.WriteLine("points than you or over 21 points.");
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine();
                        Console.WriteLine("Thanks for playing!");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Try again!");
                        break;
                }

                
            }
        }
    }
}
