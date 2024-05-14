class Assignment
{
    protected string _studentName = " ";
    protected string _topic = " ";

    public void ConstructAssignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}