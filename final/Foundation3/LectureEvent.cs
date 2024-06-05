class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity)
        :base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return $"\n{StandardDetails()} This lecture is by {_speaker}. The capacity of the venue is {_capacity} people.";
    }
    public string GetEventType()
    {
        return "Lecture";
    }
}