using mathgame.models;

namespace mathgame
{
    public class helper
    {
        public static List<game> games = new List<game> { };
        public static string? getName()
        {
            Console.WriteLine("please type your name");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("please enter a name");
                name = Console.ReadLine();  
            }
            return name;
        }

        public static void AddToHistory(int score, string gameType, int time)
        {
            games.Add(new game 
            {
                Date= DateTime.Now,
                Score= score,
                Type= gameType,
                Seconds= time
            });

        }
        public static void PrintGames()
        {
            var gamesToPrint = games;
            Console.Clear();
            Console.WriteLine("Your Game History\n");
            Console.WriteLine("--------------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date}- {game.Type}: {game.Score} pts, Speed = {game.Seconds} seconds");
            }
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadLine();
        }

        public static int[] getNumber()
        {
            Random random = new Random();
            int num1 = random.Next(1, 99);
            int num2 = random.Next(1, 99);

            while (num1 % num2 != 0)
            {
                num1 = random.Next(1, 99);
                num2 = random.Next(1, 99);
            }
            return [num1, num2];

        }
    
        public static int Validate(string input)
        {
            int retVal = 0;
            bool b = false;
            
            do
            {
                b = int.TryParse(input, out int num);
                if (b)
                {
                    retVal= num;
                }
                else
                {
                    Console.WriteLine("please enter valid number");
                    input = Console.ReadLine();
                }
            }
            while (!b);

            return retVal;
        }
    }
}
