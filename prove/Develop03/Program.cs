using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture object
        Scripture john316 = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the complete scripture
        john316.Display();

        // Prompt the user to press enter or type quit
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
        string input = Console.ReadLine();

        while (input != "quit")
        {
            // Hide a few random words
            john316.HideRandomWords();

            // Clear console and display the updated scripture
            Console.Clear();
            john316.Display();

            // Check if all words are hidden
            if (john316.AllWordsHidden())
            {
                Console.WriteLine("\nAll words hidden. Exiting...");
                return;
            }

            // Prompt the user again
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            input = Console.ReadLine();
        }
    }
}