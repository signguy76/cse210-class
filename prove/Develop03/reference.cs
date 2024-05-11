public class ScriptureReference
{
    private string Book { get; }
    private int Chapter { get; }
    private int StartVerse { get; }
    private int? EndVerse { get; }

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = null;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse == null)
            return $"{Book} {Chapter}:{StartVerse}";
        else
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}
