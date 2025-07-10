using System;
using System.Linq;//lets us use .Select()

class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string words)
    {
        _reference = reference;
        string[] wordArray = words.Split(' ');
        _words = wordArray.Select(w => new Word(w)).ToList();

    }
    public Reference GetReference()
    {
        return _reference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }

        }
        return true;
    }

}