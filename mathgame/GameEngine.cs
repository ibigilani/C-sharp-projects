﻿namespace mathgame
{
    public class GameEngine
    {
        public void addition()
        {
            int score = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition game");
                var random = new Random();
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                string input = Console.ReadLine();
                int result = helper.Validate(input);

                
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
            helper.AddToHistory(score, "Addition");

        }
        public void subtraction()
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
                string input = Console.ReadLine();
                int result = helper.Validate(input);

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
            helper.AddToHistory(score, "Subtraction");
        }
        public void multiplication()
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

                string input = Console.ReadLine();
                int result = helper.Validate(input);

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
            helper.AddToHistory(score, "Multiplication");
        }
        public void division()
        {
            int score = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Division game");
                var random = new Random();
                int[] numbers = helper.getNumber();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                string input = Console.ReadLine();
                int result = helper.Validate(input);

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
            helper.AddToHistory(score, "Division");
        }

    }
}
