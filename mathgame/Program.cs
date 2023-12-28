// See https://aka.ms/new-console-template for more information
Console.WriteLine("please type your name");
var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("-----------------------");
Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");
Console.WriteLine(@$"what game would you like to play today? Choose from the options below:
    A- Addition
    S- Subtraction
    M- Multiplication
    D- Division
    Q- Quit the program");
Console.WriteLine("-----------------------");
var game=Console.ReadLine().ToUpper();

string gameType = (game == "A" ? "addition" 
                 : game == "S" ? "Subtraction" 
                 : game == "M" ? "Multiplication" 
                 : game == "D" ? "Division" 
                 : "Invalid");

Console.WriteLine("-----------------------");
Console.WriteLine(" {0} game selected", gameType);

Console.ReadLine();
