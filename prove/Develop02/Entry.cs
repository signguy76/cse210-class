class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;

    public DateTime Date { get { return _date; } }
    public string PromptText { get { return _promptText; } }
    public string EntryText { get { return _entryText; } }

    public Entry(DateTime date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_promptText}\nEntry: {_entryText}");
        Console.WriteLine("");
    }
}
