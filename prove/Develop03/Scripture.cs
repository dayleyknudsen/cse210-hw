public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    private string v1;
    private int v2;
    private int v3;
    private string v4;


    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }
  public Scripture(string v1, int v2, int v3, string v4) : this(v1, v2, v3, v3, v4)
    {
        // This constructor calls the other constructor with the individual parameters
        // The 'v3' argument is passed both as 'endVerse' and 'text', assuming the same verse
    }
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }

    public void HideRandomWords()
    {
        int wordsToHide = _random.Next(1, _words.Count / 2);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
