using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowSpinner(5);

        Console.WriteLine("Start listing:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        _count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            items.Add(Console.ReadLine());
        }
        return items;
    }
}
