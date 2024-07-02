using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction noneGiven = new Fraction();
        Console.WriteLine(noneGiven.GetFractionString());
        Console.WriteLine(noneGiven.GetDecimalValue());

        Fraction topGiven = new Fraction(7);
        Console.WriteLine(topGiven.GetFractionString());
        Console.WriteLine(topGiven.GetDecimalValue());

        Fraction bothGiven = new Fraction(5, 8);
        Console.WriteLine(bothGiven.GetFractionString());
        Console.WriteLine(bothGiven.GetDecimalValue());

        bothGiven.SetTop(3);
        bothGiven.SetBottom(8);
        Console.WriteLine(bothGiven.GetFractionString());
        Console.WriteLine(bothGiven.GetDecimalValue());



    }
}