using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Start method to handle initial setup or menu display
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.FirstOrDefault(g => g._shortName == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            if (!goal.IsComplete())
            {
                _score += goal._points;
            }
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal._shortName}|{goal._description}|{goal._points}");
                if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal._amountCompleted}|{checklistGoal._target}|{checklistGoal._bonus}");
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    var type = parts[0];
                    var name = parts[1];
                    var description = parts[2];
                    var points = int.Parse(parts[3]);

                    if (type == nameof(SimpleGoal))
                    {
                        _goals.Add(new SimpleGoal(name, description, points));
                    }
                    else if (type == nameof(EternalGoal))
                    {
                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        var amountCompleted = int.Parse(reader.ReadLine());
                        var target = int.Parse(reader.ReadLine());
                        var bonus = int.Parse(reader.ReadLine());
                        var checklistGoal = new ChecklistGoal(name, description, points, target, bonus) 
                        {
                            _amountCompleted = amountCompleted
                        };
                        _goals.Add(checklistGoal);
                    }
                }
            }
        }
    }
}
