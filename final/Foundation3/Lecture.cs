using System;

public class Lecture : Event
{
    private string _speaker;
    private int _maxCapacity;

    public Lecture(string speaker, int maxCapacity, string title, string description, string date, string time, Address address) : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }

    public void DisplayFullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Today's speaker is: {_speaker}\n\x1b[1mMAX CAPACITY:\x1b[0m {_maxCapacity}");
    }
}