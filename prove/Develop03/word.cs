public class Word
{
    private string Text { get; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public string GetHiddenText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}


