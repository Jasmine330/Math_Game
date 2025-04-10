namespace Math_Game
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine($"Hello {name.ToUpper()}. Its {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"
What do you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Substraction
M - Multiplication
D - Division
Q - Quit the program");
                Console.WriteLine("_________________________________");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;

                    case "a":
                        gameEngine.Addition("Addition game");
                        break;

                    case "s":
                        gameEngine.Substraction("Substraction game");
                        break;

                    case "m":
                        gameEngine.Multiplication("Multiplication game");
                        break;

                    case "d":
                        gameEngine.Division("Divison game");
                        break;

                    case "q":
                        Console.WriteLine("goodbye");
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (isGameOn);
        }

    }
}