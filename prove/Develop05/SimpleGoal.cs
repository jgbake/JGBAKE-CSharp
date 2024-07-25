using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points) 
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + $"><{IsComplete()}";
    }
    public override string GetGoalType()
    {
        return "SimpleGoal";
    }
    public override string GetDisplayText()
    {
        string isCompleteRepresentation = _isComplete ? "X" : " ";
        return $"[{isCompleteRepresentation}] " + base.GetDisplayText();
    }
}