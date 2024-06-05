class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather)
        :base(title, description, date, time, address)
    {
        _weather = weather;
    }
    
    public string FullDetails()
    {
        return $"\n{StandardDetails()} For this outdoor event you should expect {_weather}";
    }
    public string GetEventType()
    {
        return "Outdoor Gathering";
    }
}