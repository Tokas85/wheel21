using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _21
{
    class Wheel
    {
        public virtual void WheelOfFortune()
        {
            Random randomNumber = new Random();

            Console.WriteLine("Welcome to the Wheel of Fortune!");
            Console.WriteLine("Choose a number between 1 and 10!");

            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber < 1 || userNumber > 10)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine("I have no patience for imbeciles!");
                Console.WriteLine("Good bye!");
                Thread.Sleep(2000);
                Environment.Exit(0);

            }
            else
            {
                int wheelNumber = randomNumber.Next(1, 11);

                Console.WriteLine($"The Wheel number is: { wheelNumber}");
                if (userNumber == wheelNumber)
                {
                    Console.WriteLine("Congratulations! You are a winner!");
                    Console.WriteLine("Thank you for playing!");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Sorry, you loose!");
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine("Good bye!");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
            
        }

        
    }
}
