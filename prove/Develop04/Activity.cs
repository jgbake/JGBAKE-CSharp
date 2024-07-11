using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected void DisplayStartingMessage()
    {
        Console.WriteLine(_name);
        Console.WriteLine("\n" + _description);
        Console.Write("\nHow many seconds would you like this activity to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    protected void DisplayEndingMessage()
    {
        Console.WriteLine("\nCongratulations! You did amazing! ");
        Spinner(2);
        Console.WriteLine($"\nYou've completed {_duration} more seconds of \"{_name}\" ");
        Spinner(2);
    }

    protected void DotDotDot()
    {
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(1000);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(1000);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(1000);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(1000);
    }
    protected void Spinner(float time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);
        while (DateTime.Now < endTime) {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    protected void DownFromThree()
    {
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
}