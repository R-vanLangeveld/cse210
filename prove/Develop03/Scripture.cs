class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public void Scriptures(Reference References, string[] text)
    {
        _reference = References;
        foreach (var word in text)
        {
            Word newWord = new Word();
            newWord.Words(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int index = random.Next(0,_words.Count);
        _words[index].Hide();
        
        for (int i = 1; i < numberToHide; i++)
        {
            index = random.Next(0,_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText();

        foreach (Word word in _words)
        {
            display += word.GetDisplayText();
        }
        return display;
    }
    public bool IsCompletelyHidden()
    {
        List<bool> hidden = new List<bool>();
        bool hid = false;
        foreach (Word word in _words) 
        {
            hidden.Add(word.IsHidden());
            if (hidden.Contains(false))
            {
                hid = false;
            }
            else
            {
                hid = true;
            }
        }
        return hid;
    }
}