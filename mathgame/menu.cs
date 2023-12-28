
namespace mathgame
{
    public class menu
    {
        GameEngine engine = new GameEngine();
        public void Menu(string? name, DateTime date)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game.\n");
            Console.WriteLine("press any key to see menu");
            Console.ReadLine();
            bool gameOn = true;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"what game would you like to play today? Choose from the options below:
V- View Games
A- Addition
S- Subtraction
M- Multiplication
D- Division
R- Random
Q- Quit the program");
                Console.WriteLine("-----------------------");
                var gameSelected = Console.ReadLine().ToUpper().Trim();


                string gameType = gameSelected == "A" ? "addition"
                                 : gameSelected == "S" ? "Subtraction"
                                 : gameSelected == "M" ? "Multiplication"
                                 : gameSelected == "D" ? "Division"
                                 : gameSelected == "R" ? "Random"
                                 : "Invalid"; // never used

                Console.WriteLine("-----------------------");
                if (gameSelected != "V")
                {
                    Console.WriteLine(" {0} game selected", gameType);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("how many questions do you want?");
                    string input = Console.ReadLine();
                    int result = helper.Validate(input);
                    engine.numOfGames = result;
                }
                if (gameSelected == "Q")
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Thanks for playing");
                    gameOn = false;
                    Environment.Exit(1);
                }

                

                switch (gameSelected)
                {
                    case "R":
                        string[] arr = { "A", "S","M", "D" };
                        Random rand = new Random();
                        int index= rand.Next(arr.Length);
                        string randGame = arr[index];
                        if (randGame == "A") 
                        { 
                            goto case "A";
                        }
                        else if (randGame == "S")
                        {
                            goto case "S";
                        }
                        else if(randGame == "M")
                        {
                            goto case "M";
                        }
                        else 
                        {
                            goto case "D";
                        }


                    case "V":
                        helper.PrintGames();
                        break;
                    case "A":
                        engine.addition();
                        break;
                    case "S":
                        engine.subtraction();
                        break;
                    case "M":
                        engine.multiplication();
                        break;
                    case "D":
                        engine.division();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }

            while (gameOn);

        }

    }
}
