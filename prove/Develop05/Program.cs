using System;

public class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    RecordEvent(goalManager);
                    break;
                case "3":
                    goalManager.ListGoalDetails();
                    goalManager.DisplayPlayerInfo();
                    break;
                case "4":
                    SaveGoals(goalManager);
                    break;
                case "5":
                    LoadGoals(goalManager);
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string goalType = Console.ReadLine();

        Console.WriteLine("Enter Goal Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Goal Description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Goal Points:");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                goalManager.CreateGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                goalManager.CreateGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter Target Count:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Bonus Points:");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalManager.CreateGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Enter Goal Name:");
        string name = Console.ReadLine();
        goalManager.RecordEvent(name);
    }

    static void SaveGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter filename to save:");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
    }

    static void LoadGoals(GoalManager goalManager)
    {
        Console.WriteLine("Enter filename to load:");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
    }
}
