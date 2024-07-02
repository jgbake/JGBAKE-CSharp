using System;

public class Journal
{
    public List<Entry> _journalEntries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _journalEntries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine("---------------------------------------------------------------------");
        foreach (Entry currentEntry in _journalEntries)
        {
            currentEntry.DisplayEntry();
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter currentFile = new StreamWriter(fileName))
        {
            foreach (Entry currentEntry in _journalEntries)
            {
                string saveDate = currentEntry._date;
                string saveAuthor = currentEntry._entryAuthor;
                string savePrompt = currentEntry._promptText;
                string saveEntryText = currentEntry._entryText;
                currentFile.WriteLine($"{saveDate}><{saveAuthor}><{savePrompt}><{saveEntryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        _journalEntries.Clear();
        try
        {
            string[] fileLines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in fileLines)
            {
                string[] parts = line.Split("><");
                Entry currentLoadingEntry = new Entry();

                currentLoadingEntry._date = parts[0];
                currentLoadingEntry._entryAuthor = parts[1];
                currentLoadingEntry._promptText = parts[2];
                currentLoadingEntry._entryText = parts[3];
            
                _journalEntries.Add(currentLoadingEntry);
            }
        }    
        catch (Exception x)
        {
            Console.WriteLine(x.Message);
        }
    }
}