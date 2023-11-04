public class ScriptureWord
{
    public string Word { get; set; }
    public bool Hidden { get; set; }

    public ScriptureWord(string word)
    {
        Word = word;
        Hidden = false;
    }
}