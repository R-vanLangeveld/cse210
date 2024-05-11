class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public void References(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public void References(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string displayReference ="";
        if (_endVerse > _verse)
        {
            displayReference = $"{_book}{_chapter}:{_verse}-{_endVerse}";
        }
        else 
        {
            displayReference = $"{_book}{_chapter}:{_verse}";
        }
        return displayReference;
    }
}