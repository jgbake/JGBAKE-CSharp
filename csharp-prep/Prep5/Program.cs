using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welsome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string theName = Console.ReadLine();
        return theName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favNum = int.Parse(Console.ReadLine());
        return favNum;
    }
    static double SquareNumber(int num)
    {
        return Math.Round(Math.Sqrt(num), 3);
    }
    static void DisplayResult(string userName, double userNumSquare)
    {
        Console.WriteLine($"{userName}, the square of your number is: {userNumSquare}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        double userNumSquare = SquareNumber(userNum);
        DisplayResult(userName, userNumSquare);
    }
}