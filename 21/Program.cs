using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {

            Wheel wheelOfFurtune = new Wheel();
            _21 game21 = new _21();

            Console.WriteLine("Please choose what game to play:");
            Console.WriteLine("(1) Wheel of Fortune");
            Console.WriteLine("(2) Card game \"21\"");

            var menuInput = true;
            while (menuInput)
            {
                var chooseGame = Console.ReadKey();
                Console.WriteLine();
                switch (chooseGame.Key)
                {
                    case ConsoleKey.D1:
                        wheelOfFurtune.WheelOfFortune();
                        break;

                    case ConsoleKey.D2:
                        game21.Game21();
                        break;

                    default:
                        Console.WriteLine("Wrong input!");
                        Console.Write("Try again: ");
                        break;
                }
            }
            






        }
    }
}
