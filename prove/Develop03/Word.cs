class Word
{
    public string Text { get; }
    public int Index { get; }
    public bool IsHidden { get; private set; }

    public Word(string text, int index)
    {
        Text = text;
        Index = index;
        IsHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        IsHidden = true;
    }
}