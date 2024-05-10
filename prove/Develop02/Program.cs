using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Random prompt: {randomPrompt}");
        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();
        theJournal._entries.Add(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), randomPrompt, response));
        theJournal.DisplayAll();
    }
}
