public class Scripture
{
    private readonly List<Word> words;

    public Scripture(ScriptureReference reference, string text)
    {
        words = text.Split(' ').Select(w => new Word(w)).ToList();
        Reference = reference;
    }

    public ScriptureReference Reference { get; }

    public void HideRandomWord()
    {
        var hiddenWords = words.Where(w => w.IsHidden).ToList();
        var unhiddenWords = words.Where(w => !w.IsHidden).ToList();
        if (unhiddenWords.Count > 0)
        {
            var random = new Random();
            var index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].IsHidden = true;
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(" ", words.Select(w => w.GetHiddenText()))}";
    }
}
