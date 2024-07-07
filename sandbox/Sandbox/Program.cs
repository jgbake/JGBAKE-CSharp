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
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        DotDotDot();
    }
}