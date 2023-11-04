public class ScriptureReference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int StartVerse { get; set; }
    public int EndVerse { get; set; }

    public ScriptureReference(string reference)
    {
        // Parse the reference (e.g., "John 3:16" or "Proverbs 3:5-6")
        // and set the Book, Chapter, StartVerse, and EndVerse properties.
    }
}
