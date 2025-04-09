var date = DateTime.UtcNow;

var games = new List<string>();

string? name = GetName();

Menu(name);

void Menu(string? name)
{
    Console.WriteLine("_________________________________");
    Console.WriteLine($"Hello {name.ToUpper()}. Its {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");

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
                GetGames();
                break;

            case "a":
                Addition("Addition game");
                break;

            case "s":
                Substraction("Substraction game");
                break;

            case "m":
                Multiplication("Multiplication game");
                break;

            case "d":
                Division("Divison game");
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

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("_\n");
    Console.WriteLine("Press any key to return to Main Menu");
    Console.ReadLine();
}

string GetName()
{
    Console.WriteLine("Please enter your name: ");
    var name = Console.ReadLine();
    return name;
}

void Addition(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("You answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
    }

    AddToHistory(score, "Addition");
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType} : {gameScore}");
}

void Substraction(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("You answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to continue the game.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Substraction");
}

void Multiplication(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("You answer was correct! Press any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect!. Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to continue the game.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Multiplication");
}

void Division(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine($"Your answer was correct. Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Your answer was incorrect. Press any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to continue the game.");
            Console.ReadLine();
        }
    }
    AddToHistory(score, "Division");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(0, 99);
        secondNumber = random.Next(0, 99);
    }
    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}