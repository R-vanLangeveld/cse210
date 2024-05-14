class MathAssignment : Assignment
{
    private string _textbookSection = " ";
    private string _problems = " ";

    public void ConstructMathAssignment(string name, string topic, string book, string problems)
    {
        _textbookSection = book;
        _problems = problems;
        ConstructAssignment(name, topic);
    }

    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }
}