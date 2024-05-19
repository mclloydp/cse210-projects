using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        DisplayStartingMessage();
        int timePerCycle = 5; // Seconds for each breathe in/out cycle
        for (int i = 0; i < _duration; i += timePerCycle * 2)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(timePerCycle);
            Console.WriteLine("Breathe out...");
            ShowCountDown(timePerCycle);
        }
        DisplayEndingMessage();
    }
}
