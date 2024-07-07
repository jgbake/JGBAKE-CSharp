using System;
class Program
{
    static void DotDotDot()
    {
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(800);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(800);
        Console.Write(Convert.ToChar(176));
        Thread.Sleep(800);
        Console.Write("\b\b\b   \b\b\b");
        Thread.Sleep(800);
    }

    static public void Spinner(int time)
    {
        Console.Write("-");
        Thread.Sleep(time / 4);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(time / 4);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(time / 4);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(time / 4);
        Console.Write("\b \b");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        DotDotDot();
        Thread.Sleep(1000);
        do {Spinner(1000);Console.Write("\b \b");} while (true);
    }
}