using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Enter Book Title: ");
        string bookTitle = Console.ReadLine();
        Console.Write("\nEnter Chapter #: ");
        int chapNum = int.Parse(Console.ReadLine());
        Console.Write("\nHow Many Verses?: ");
        int verseCount = int.Parse(Console.ReadLine());
        Reference currentVerseReference;
        string verseText = "";
        if (verseCount == 1)
        {
            Console.Write("\nEnter Verse #: ");
            int verse = int.Parse(Console.ReadLine());
            currentVerseReference = new Reference(bookTitle, chapNum, verse);
            Console.WriteLine("\nType Verse (text only): ");
            verseText = Console.ReadLine();
        }
        else if (verseCount >= 2)
        {
            Console.Write("\nEnter Start Verse #: ");
            int startVerse = int.Parse(Console.ReadLine());
            Console.Write("\nEnter End Verse #: ");
            int endVerse = int.Parse(Console.ReadLine());
            currentVerseReference = new Reference(bookTitle, chapNum, startVerse, endVerse, verseCount);
            Console.WriteLine("\nType Verses (text only) (put a // in between): ");
            verseText = Console.ReadLine();
        }
        else 
        {
            Console.WriteLine("ERROR");
            Environment.Exit(0);
            currentVerseReference = new Reference("ERROR", 0, 0);
        }
        Scripture currentScripture = new Scripture(currentVerseReference, verseText);

        bool exitCase = false;
        do {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue, type quit to exit");
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
                    Console.Write("How many words do you want to hide? ");
                    currentScripture.HideRandomWords(int.Parse(Console.ReadLine()));
                }
                exitCase = false;
            }
        } while (exitCase == false);
    }
}