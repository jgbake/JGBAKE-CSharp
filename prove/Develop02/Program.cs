using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGen = new PromptGenerator();
        promptGen._prompts.Add("What was the weather like today?");
        promptGen._prompts.Add("What was the most important thing you remember about today?");
        promptGen._prompts.Add("What did you do for fun?");
        promptGen._prompts.Add("What did you eat for breakfast?");
        promptGen._prompts.Add("If you could change something that happened today, what would you??");
        promptGen._prompts.Add("Who was your favorite person you talked to today, and why?");
        Journal currentJournal = new Journal();
        bool exitCase = false;

        Console.WriteLine("Welcome to your Journal");
        Console.Write("Who is writing today? ");
        string currentAuthor = Console.ReadLine();
        do {
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal (overwrites entire file)");
            Console.WriteLine("4. Load Journal File (deletes unsaved entries)");
            Console.WriteLine("5. Exit");
            Console.Write("# of option: ");
            int numChoice = int.Parse(Console.ReadLine());

            if (numChoice == 1)
            {
                Entry currentEntry = new Entry();
                currentEntry._date = DateTime.Now.ToShortDateString();
                currentEntry._entryAuthor = currentAuthor;
                Console.WriteLine($"Date: {currentEntry._date} Author: {currentEntry._entryAuthor}");
                currentEntry._promptText = promptGen.GetRandomPrompt();
                Console.WriteLine(currentEntry._promptText);
                Console.Write("> ");
                currentEntry._entryText = Console.ReadLine();
                currentJournal.AddEntry(currentEntry);
            }
            else if (numChoice == 2)
            {
                currentJournal.DisplayAll();
            }
            else if (numChoice == 3)
            {
                Console.Write("What file would you like to save to? ");
                currentJournal.SaveToFile(Console.ReadLine());
            }
            else if (numChoice == 4)
            {
                Console.WriteLine("What file would you like to read?");
                currentJournal.LoadFromFile(Console.ReadLine());
            }
            else if (numChoice == 5)
            {
                Console.WriteLine("Goodbye!");
                exitCase = true;
            }
            else
            {
                Console.WriteLine("CHOICE ERROR: Try Again");
            }
        } while (exitCase == false);
    }
}