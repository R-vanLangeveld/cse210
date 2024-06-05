class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.GetAddress();
    }

    public string StandardDetails()
    {
        return $"{_title}, {_description} On {_date} at {_time}. The event's location is {_address}.";
    }
    public string ShortDescription(string eventType)
    {
        return $"\n{eventType}, {_title}, {_date}";
    }
}