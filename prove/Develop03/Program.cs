using System;
class Program
{
    static void Main(string[] args)
    {
        // Example scripture
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create a Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Display the complete scripture
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");

        // Main loop
        while (!scripture.IsCompletelyHidden())
        {
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                break;
            }
            else
            {
                // Hide some random words
                scripture.HideRandomWords(2); // Change the number as desired
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            }
        }

        Console.WriteLine("Program ended.");
    }
}