using System;
using System.ComponentModel.Design;

class Program
{
    public static int boxesBreathed = 0;
    public static int listedResponses = 0;
    public static int statementsReflected = 0;
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("What would you like to accomplish today?");
        Console.WriteLine("  1. Breathing Exercise");
        Console.WriteLine("  2. Listing Activity");
        Console.WriteLine("  3. Reflection");
        Console.WriteLine("  4. Quit");
        
        Console.Write("\nChosen number: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice) 
        {
            case 1:
                BreathingActivity currBreathAct = new BreathingActivity();
                Console.Clear();
                boxesBreathed += currBreathAct.Run();
                break;
            case 2:
                ListingActivity currListingAct = new ListingActivity();
                Console.Clear();
                listedResponses += currListingAct.Run();
                break;
            case 3:
                ReflectingActivity currReflectingAct = new ReflectingActivity();
                Console.Clear();
                statementsReflected += currReflectingAct.Run();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine($"Today you:\n - Breathed {boxesBreathed} Boxes\n - Listed {listedResponses} Responses\n - Reflected on {statementsReflected} Statements\n\nGoodbye!\n");
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Oops, Choice Error");
                Thread.Sleep(1000);
                break;
        }
    }
    static void Main(string[] args)
    {
        do {
            Menu();
        } while (true);
    }
}