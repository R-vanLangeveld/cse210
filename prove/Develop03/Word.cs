using System.Text.RegularExpressions;
class Word
{
    private string _text;
    private bool _isHidden;

    public void Words(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        Regex pattern = new Regex("[abcdefghijklmnopqrstuvwxyz]");
        _text = pattern.Replace(_text.ToLower(), "_");
        _isHidden = true;
    }
    private void Show()
    {
        // I have no idea what to do with this function. The words are already being printed 
        // to the console with the GetDisplayText sent to Scripture's GetDisplayText. 
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        string space = " ";
        string displayWord = space + _text;
        return displayWord;
    }
}