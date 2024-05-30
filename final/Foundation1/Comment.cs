// Class to track comments
public class Comment
{
    public string _commenterName { get; set; }
    public string _text { get; set; }

    public Comment(string name, string text)
    {
        _commenterName = name;
        _text = text;
    }
}

