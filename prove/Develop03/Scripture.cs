using System;
using System.Threading.Tasks.Dataflow;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scriptWords = new List<Word>();

    public Scripture()
    {
        string[] scriptFile = File.ReadAllLines("scriptures.txt");
        Random randomScripture = new Random();
        string verseProcessing = scriptFile[randomScripture.Next(0,21)];
        {
            string[] parts = verseProcessing.Split("><");
            if (int.Parse(parts[0]) == 1)
            {
                _reference = new Reference(parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                string[] words = parts[4].Split(" ");
                foreach (string word in words)
                {
                    _scriptWords.Add(new Word(word));
                }
            }
            else if (int.Parse(parts[0]) > 1)
            {
                _reference = new Reference(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                string[] words = parts[5].Split(" ");
                foreach (string word in words)
                {
                    _scriptWords.Add(new Word(word));
                }
            }
        }
    }

    public void HideRandomWords()
    {
        Random randomWordIndex = new Random();
        int toHide = 3;
        while (toHide != 0)
        {
            bool wordHidden = false;
            while (wordHidden == false)
            {
                int wordIndex = randomWordIndex.Next(0,_scriptWords.Count);
                if (_scriptWords[wordIndex].IsHidden() == true)
                {
                    if (IsCompletelyHidden() == true)
                    {
                        wordHidden = true;
                    }
                    else
                    {
                        wordHidden = false;
                    }
                }
                else if (_scriptWords[wordIndex].GetDisplayText() == "SEPARATOR")
                {
                    wordHidden = false;
                }
                else 
                {
                _scriptWords[wordIndex].Hide();
                wordHidden = true;
                }
            }
            toHide -= 1;
        }
    }

    public string GetDisplayText()
    {
        int currentVerse = _reference.GetFirstVerse();
        string toDisplay = $"\n\x1b[1m{_reference.GetDisplayText()}\n\n";
        string currentLine = $"   {currentVerse}\x1b[0m ";
        foreach (Word word in _scriptWords)
        {
            if (word.GetDisplayText() == "SEPARATOR")
            {
                toDisplay += currentLine;
                currentVerse += 1;
                currentLine = $"\n\n   \x1b[1m{currentVerse}\x1b[0m ";
            }
            else if (currentLine.Length > 64)
            {
                toDisplay += currentLine;
                currentLine = "\n   " + word.GetDisplayText() + " ";
            }
            else
            {
                currentLine += word.GetDisplayText() + " ";
            }
        }

        toDisplay += currentLine;
        return toDisplay;
    }

    public bool IsCompletelyHidden()
    {
        bool isTrue = true;
        foreach (Word word in _scriptWords)
        {
            if ((word.IsHidden() == false) && (word.GetDisplayText() != "SEPARATOR"))
            {
                isTrue = false;
            }
        }
        return isTrue;
    }
}