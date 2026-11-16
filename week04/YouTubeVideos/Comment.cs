public class Comment
{
    private readonly string _commenterName;
    private readonly string _text;

    public Comment(string name, string text)
    {
        _commenterName = name ?? string.Empty;
        _text = text ?? string.Empty;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }
}
