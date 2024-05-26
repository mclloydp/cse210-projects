public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                _points += _bonus;
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points each time, bonus {_bonus} points on completion";
    }

    public string GetChecklistString()
    {
        return $"Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return IsComplete() ? $"[X] {_shortName} ({GetChecklistString()})" : $"[ ] {_shortName} ({GetChecklistString()})";
    }
}
