using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int GetPoints()
    {
        if ((_amountCompleted % _target == 0) && (_amountCompleted != 0))
        {
            return _bonus;
        }
        else
        {
            return base.GetPoints();
        }
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"><{_target}><{_bonus}><{_amountCompleted}";
    }
    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }
    public override string GetDisplayText()
    {
        return $"[{_amountCompleted % _target}/{_target}] " + base.GetDisplayText();
    }
}