using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryAuthor;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} Author: {_entryAuthor}");
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}