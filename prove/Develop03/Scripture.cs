// Class to represent a scripture
class Scripture
{
    private string reference;
    private string text;
    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = text.Split(' ').Select((word, index) => new Word(word, index)).ToList();
    }

    // Display the scripture with hidden words
    public void Display()
    {
        Console.WriteLine($"Scripture: {reference}");
        foreach (var word in words)
        {
            Console.Write(word.IsHidden ? "_____ " : $"{word.Text} ");
        }
    }

    // Hide a few random words in the scripture
    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, words.Count / 2); // hide up to all of the words
        int count = 0;

        while (count < wordsToHide)
        {
            int index = random.Next(0, words.Count);
            if (!words[index].IsHidden)
            {
                words[index].Hide();
                count++;
            }
        }
    }

    // Check if all words are hidden
    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }
}

    