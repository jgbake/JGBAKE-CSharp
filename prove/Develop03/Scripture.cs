using System;
using System.Threading.Tasks.Dataflow;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scriptWords = new List<Word>();
    private List<List<Word>> _verses = new List<List<Word>>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] verses = text.Split("//");
        foreach (string verse in verses)
        {
            string[] words = verse.Split(" ");
            foreach (string word in words)
            {
                _scriptWords.Add(new Word(word));
            }
            _scriptWords.Add(new Word("SEPARATOR"));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomWordIndex = new Random();
        while (numberToHide != 0)
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
            numberToHide -= 1;
        }
    }

    public string GetDisplayText()
    {
        string toDisplay = $"{_reference.GetDisplayText()}\n";
        foreach (Word word in _scriptWords)
        {
            if (word.GetDisplayText() == "SEPARATOR")
            {
                toDisplay += "\n";
            }
            else
            {
                toDisplay += word.GetDisplayText() + " ";
            }
        }
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