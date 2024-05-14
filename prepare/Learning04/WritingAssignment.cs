class WritingAssignment : Assignment
{
    private string _title = " ";

    public void ConstructWritingAssignment(string title, string name, string topic)
    {
        _title = title;
        ConstructAssignment(name, topic);
    }

    public string GetWritingInformation()
    {
        return _title + " " + _studentName;
    }
}