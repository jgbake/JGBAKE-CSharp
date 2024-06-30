using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput;
        string letter;
        Console.Write("What is your grade percentage? ");
        userInput = int.Parse(Console.ReadLine());

        if ((100 >= userInput) && (userInput >= 90))
        {
            letter = "A";
        }
        else if ((90 > userInput) && (userInput >= 80))
        {
            letter = "B";
        }
        else if ((80 > userInput) && (userInput >= 70))
        {
            letter = "C";
        }
        else if ((70 > userInput) && (userInput >= 60))
        {
            letter = "D";
        }
        else if ((60 > userInput) && (userInput >= 0))
        {
            letter = "F";
        }
        else
        {
            letter = "GRADE ERROR";
        }
        Console.WriteLine($"Your letter grade is: {letter}");
        
        if ((letter == "A") || (letter == "B") || (letter == "C"))
        {
            Console.WriteLine("You Pass!");
        }
        else if (letter == "GRADE ERROR")
        {
            Console.WriteLine("Something weird happened... Try Again");
        }
        else
        {
            Console.WriteLine("You Fail! Try again next semester!");
        }
    }
}