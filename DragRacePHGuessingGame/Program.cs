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
            "Finally! I'm here! Bring it on, girls!",
            "Happy Fiesta! Mga Sis! Diyan muna kayo sa likod tatawagin na lang kapag may tira.",
            "Mirror Mirror on the wall, who's the baddest bitch of them all?",
            "Time Time! And I'm ready seat that throne, Bitches!",
            "Hello mga kaibigan with feelings!",
            "Just like summer this is my season!",
            "Pilipinas! Fresh ka pa ba?",
            "AAAAHHHHYYYY! Echos!",
            "Of course!",
            "Let's do this!",
            "Nandiyan pala kayo?! Mayghad!",
            "I see stalkers, oh there they are, Hi kids!"
            };

            Console.WriteLine("🌟 DRAG RACE PHILIPPINES QUOTETIVITY GUESSING GAME 🌟");
            Console.WriteLine("Choose your Season:");
            Console.WriteLine("1. Season 1 - AVAILABLE ✨");
            Console.WriteLine("2. Season 2 - HINDI PA NAGAGAWA TEH 🚧");
            Console.WriteLine("3. Season 3 - HINDI PA RIN NGA NAGAGAWA 🚧");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose: ");

            string userInput = Console.ReadLine();
            Console.WriteLine("You chose: " + userInput);
        }
    }
}

