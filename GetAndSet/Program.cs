using System;

namespace MiniGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Game class
            Game game = new Game();

            while (true)
            {
                // Display the current game number
                Console.WriteLine("Game " + game.GameNumber);

                // Get the user's input
                Console.Write("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                // Set the user's input in the Game class
                game.UserInput = userInput;

                // Check if the user's input is equal to the random number
                if (game.UserInput == game.RandomNumber)
                {
                    Console.WriteLine("Correct!");
                    game.Score++;
                }
                else
                {
                    Console.WriteLine("Incorrect.");
                }

                // Increment the game number
                game.GameNumber++;

                // Display the current score
                Console.WriteLine("Score: " + game.Score);
            }
        }
    }

    class Game
    {
        // Private fields to store the game number and user's input
        private int gameNumber = 1;
        private int userInput;

        // Public property to get and set the game number
        public int GameNumber
        {
            get { return gameNumber; }
            set { gameNumber = value; }
        }

        // Public property to get and set the user's input
        public int UserInput
        {
            get { return userInput; }
            set { userInput = value; }
        }

        // Private field to store the random number
        private int randomNumber;

        // Public property to get the random number
        public int RandomNumber
        {
            get
            {
                Random random = new Random();
                randomNumber = random.Next(1, 11);
                return randomNumber;
            }
        }

        // Private field to store the score
        private int score = 0;

        // Public property to get and set the score
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}
