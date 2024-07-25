using System;
using System.Text.RegularExpressions;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, string date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"\x1b[1m{_title}\x1b[0m\n{_date} at {_time}");
        Console.Write(Regex.Replace(_description, @"(.{1," + 48 +@"})(?:\s|$)", "$1\n"));
        Console.Write($"\n\x1b[1mLocation:\x1b[0m\n{_address.FullAddress()}\n");
    }
    public void FullDetails()
    {
        Console.WriteLine($"\x1b[1m{_eventType}:\x1b[0m");
        StandardDetails();
        Console.WriteLine("\n\x1b[1mIMPORTANT INFORMATION:\x1b[0m");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"{_eventType}\n{_title}\n{_date}");
    }
}