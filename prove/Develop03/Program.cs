using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture currentScripture = new Scripture();
        bool exitCase;
        do {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue and hide, type quit to exit");
            string answer = Console.ReadLine();
            if (answer == "quit")
            {
                exitCase = true;
            }
            else
            {
                if (currentScripture.IsCompletelyHidden() == true)
                {
                    Console.WriteLine("Congrats! Everything is hidden now!\n");
                    System.Environment.Exit(0);
                }
                else
                {
                    currentScripture.HideRandomWords();
                }
                exitCase = false;
            }
        } while (exitCase != true);
    }
}