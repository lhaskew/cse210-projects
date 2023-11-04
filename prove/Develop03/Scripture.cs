using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    public List<ScriptureWord> Words { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = new ScriptureReference(reference);
        Words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }

    public void HideRandomWord()
    {
        // Randomly select a word that is not already hidden and mark it as hidden.
    }
}
