namespace DragRacePHGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] queens =
            {"Brigiding", "Corazon", "Eva Le Queen", "Gigi Era",
            "Lady Morgana", "Marina Summers", "Minty Fresh", "Precious Paula Nicole",
            "Prince", "Turing", "Viñas DeLuxe", "Xilhouete" };

            string[] quotes = {
            "Finally! I'm here! Bring it on, girls!",           							// 1. Brigiding
            "Happy Fiesta! Mga Sis! Diyan muna kayo sa likod tatawagin na lang kapag may tira.", 	// 2. Corazon
            "Mirror Mirror on the wall, who's the baddest bitch of them all?", 						// 3. Eva Le Queen
            "Time Time! And I'm ready seat that throne, Bitches!",									// 4. Gigi Era
            "Hello mga kaibigan with feelings!",                									// 5. Lady Morgana
            "Just like summer this is my season!",              									// 6. Marina Summers
            "Pilipinas! Fresh ka pa ba?",                       									// 7. Minty Fresh
            "AAAAHHHHYYYY! Echos!",                            										// 8. Precious Paula Nicole
            "Of course!",                                       									// 9. Prince
            "Let's do this!",                                   									// 10. Turing
            "Nandiyan pala kayo?! Mayghad!",                   										// 11. Viñas DeLuxe
            "I see stalkers, oh there they are, Hi kids!"      										// 12. Xilhouete
            };

            Random random = new Random();
            bool Menu = true;


            while (Menu)
            {

                Console.WriteLine("🌟 DRAG RACE PHILIPPINES QUOTETIVITY GUESSING GAME 🌟");
                Console.WriteLine("Choose your Season:");
                Console.WriteLine("1. Season 1 - AVAILABLE ✨");
                Console.WriteLine("2. Season 2 - HINDI PA NAGAGAWA TEH 🚧");
                Console.WriteLine("3. Season 3 - HINDI PA RIN NGA NAGAGAWA 🚧");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose (1-4): ");

                int SeasonInput = int.Parse(Console.ReadLine());

                if (SeasonInput == 1)
                {
                    bool PlayAgain = true;
                    while (PlayAgain)
                    {
                        Console.Clear();

                        // Queens Random Quotivity
                        int randomIndex = random.Next(quotes.Length);
                        string currentQuote = quotes[randomIndex];
                        int correctAnswer = randomIndex + 1;

                        // Quote Keme
                        Console.WriteLine("🎤 SEASON 1 - GUESS THE QUEEN! 🎤");
                        Console.WriteLine($"Quote: \"{currentQuote}\"");
                        Console.WriteLine();

                        // Show all Drag Queens
                        for (int i = 0; i < queens.Length; i++)
                        { Console.WriteLine(queens[i]); }

                        // Get user's Input Guesss
                        Console.WriteLine();
                        Console.Write("Your answer (1-12): ");
                        int userGuess = int.Parse(Console.ReadLine());

                        // Check Answer ni User Accla
                        Console.WriteLine();
                        if (userGuess == correctAnswer)
                        {
                            Console.WriteLine("✨ SHANTAY YOU STAY! ✨");
                            Console.WriteLine("Tama! You know your queens!");
                        }
                        else
                        {
                            Console.WriteLine("SASHAY AWAY! </3");
                            Console.WriteLine($"Mali! It was {queens[correctAnswer - 1]}");
                        }

                        // Play pa ba or naur na
                        Console.WriteLine();
                        Console.WriteLine("1. Play Again");
                        Console.WriteLine("2. Back to Main Menu");
                        Console.Write("Choose (1-2): ");

                        int nextChoice = int.Parse(Console.ReadLine());

                        if (nextChoice == 2)
                        {
                            PlayAgain = false;
                        }
                    }
                }

                else if (SeasonInput == 2 || SeasonInput == 3)
                {

                }

            }
        }
    }
}

