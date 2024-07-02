using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private int _numVerses;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse, int numVerses)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _numVerses = numVerses;
    }

    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}, {_verse}";
        }
        else 
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
    public int VerseCount()
    {
        return _numVerses;
    }
}