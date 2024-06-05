class ReceptionEvent : Event
{
    private string _RSVP;

    public ReceptionEvent(string title, string description, string date, string time, Address address, string RSVP)
        :base(title, description, date, time, address)
    {
        _RSVP = RSVP;
    }
    
    public string FullDetails()
    {
        return $"\n{StandardDetails()} RSVP to {_RSVP}";
    }
    public string GetEventType()
    {
        return "Reception";
    }
}