
string? name = getName();
var date = DateTime.UtcNow;

Menu(name);


string? getName()
{
    Console.WriteLine("please type your name");
    var name = Console.ReadLine();
    return name;
}
void Menu(string? name)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");

    bool gameOn = true;
    do 
    {
        Console.WriteLine(@$"what game would you like to play today? Choose from the options below:
                            A- Addition
                            S- Subtraction
                            M- Multiplication
                            D- Division
                            Q- Quit the program");
        Console.WriteLine("-----------------------");
        var gameSelected = Console.ReadLine().ToUpper().Trim();


        string gameType = gameSelected == "A" ? "addition"
                         : gameSelected == "S" ? "Subtraction"
                         : gameSelected == "M" ? "Multiplication"
                         : gameSelected == "D" ? "Division"
                         : "Invalid";

        Console.WriteLine("-----------------------");
        Console.WriteLine(" {0} game selected", gameType);
        if (gameSelected == "Q")
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Thanks for playing");
            Environment.Exit(1);
        }

        Program p = new Program();

        switch (gameSelected)
        {
            case "A":
                addition();
                break;
            case "S":
                subtraction();
                break;
            case "M":
                multiplication();
                break;
            case "D":
                division();
                break;
            default:
                Console.WriteLine("Invalid input");
                Environment.Exit(1);
                break;

        }
    }

    while (gameOn);
    
}
void addition()
{
    int score = 0;
    for(int i = 0; i<3; i++)
    {
        Console.Clear();
        Console.WriteLine("Addition game");
        var random = new Random();
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        int result = int.Parse(Console.ReadLine());
        if (result == (firstNumber + secondNumber))
        {
            Console.WriteLine("you got it right! Type any key for next question");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Uh oh that's not quite right... Type any key for next question");
            Console.ReadLine();
        }
    }

    Console.WriteLine("GAME OVER. your score is {0}. Press any key to go to the main menu", score);
    Console.ReadLine();

}
void subtraction()
{
    int score = 0;
    for (int i = 0; i < 3; i++)
    {
        Console.Clear();
        Console.WriteLine("Subtraction game");
        var random = new Random();
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        int result = int.Parse(Console.ReadLine());
        if (result == (firstNumber - secondNumber))
        {
            Console.WriteLine("you got it right! Type any key for next question");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Uh oh that's not quite right... Type any key for next question");
            Console.ReadLine();
        }
    }

    Console.WriteLine("GAME OVER. your score is {0}. Press any key to go to the main menu", score);
    Console.ReadLine();

}
void multiplication()
{
    int score = 0;
    for (int i = 0; i < 3; i++)
    {
        Console.Clear();
        Console.WriteLine("Multiplication game");
        var random = new Random();
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        int result = int.Parse(Console.ReadLine());
        if (result == (firstNumber * secondNumber))
        {
            Console.WriteLine("you got it right! Type any key for next question");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Uh oh that's not quite right... Type any key for next question");
            Console.ReadLine();
        }
    }

    Console.WriteLine("GAME OVER. your score is {0}. Press any key to go to the main menu", score);
    Console.ReadLine();


}
void division()
{
    int score = 0;
    for (int i = 0; i < 3; i++)
    {
        Console.Clear();
        Console.WriteLine("Division game");
        var random = new Random();
        int[] numbers = getNumber();
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        int result = int.Parse(Console.ReadLine());
        if (result == (firstNumber / secondNumber))
        {
            Console.WriteLine("you got it right! Type any key for next question");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Uh oh that's not quite right... Type any key for next question");
            Console.ReadLine();
        }
    }

    Console.WriteLine("GAME OVER. your score is {0}. Press any key to go to the main menu", score);
    Console.ReadLine();
}

int[] getNumber()
{
    Random random = new Random();
    int num1= random.Next(1, 99);
    int num2 = random.Next(1, 99);

    while(num1 % num2 != 0) {
         num1 = random.Next(1, 99);
         num2 = random.Next(1, 99);
    }
    return [num1, num2];

}







