namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool play = true;
            Console.WriteLine("WELCOME");

            while (play == true)
            {
                Console.WriteLine("Guess the number.");
                int playerGuess = Convert.ToInt32(Console.ReadLine());
                Random computerNumRND = new Random();
                int computerChoice = computerNumRND.Next(1, 10);
                if (playerGuess == computerChoice)
                {
                    Console.WriteLine($"Player Guess: {playerGuess}");
                    Console.WriteLine($"Computer Choice: {computerChoice}");

                    Console.WriteLine("CONGRATULATİONS! You guess right!");
                } else
                {
                    Console.WriteLine("Try Again...");
                }


            }

        }
    }
}