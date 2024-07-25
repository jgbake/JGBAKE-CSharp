using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual string GetDisplayText()
    {
        return $"{_shortName} ({_description})";
    }
    public abstract string GetGoalType();
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetStringRepresentation()
    {
        return $"{GetGoalType()}><{_shortName}><{_description}><{_points}";
    }
    public virtual string GetDetailsString()
    {
        return "";
    }
}