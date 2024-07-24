using System;
using System.ComponentModel;

public class Activity
{
    private DateOnly _theDate;
    private string _activityName;
    private float _activityLength;

    public Activity(DateOnly theDate, string activityName, float activityLength)
    {
        _theDate = theDate;
        _activityName = activityName;
        _activityLength = activityLength;
    }

    public float GetActivityLength() {return _activityLength;}
    public virtual float GetDistance() {return 0;}
    public virtual float GetSpeed() {return 0;}
    public virtual float GetPace() {return 0;}
    public string GetSummary()
    {
        string toReturn;
        toReturn = $" > \x1b[1m{_theDate.Day} {_theDate:MMMM} {_theDate.Year} {_activityName} ({_activityLength} min)\x1b[0m - ";
        toReturn += $"Distance: {Math.Round(GetDistance(), 2)} miles - Speed: {Math.Round(GetSpeed(), 2)} mph - Pace: {Math.Round(GetPace(), 2)} min per mile";
        return toReturn;
    }
}