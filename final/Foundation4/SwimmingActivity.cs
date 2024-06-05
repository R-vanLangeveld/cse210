class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, int minutes, double laps)
        :base(date, minutes)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return _laps * 50 / 1000;
    }
    public override double Speed()
    {
        return Math.Round(Distance() / _minutes * 60, 2);
    }
    public override double Pace()
    {
        return _minutes / Distance();
    }
    public override string GetSummary()
    {
        
        return $"{_date} Swimming ({_minutes} min): Distance {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
}