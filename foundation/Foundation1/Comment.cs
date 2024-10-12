public class Comment
{
    // Properties
    public string Name { get; private set; }
    public string Text { get; private set; }

    // Constructor
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}
