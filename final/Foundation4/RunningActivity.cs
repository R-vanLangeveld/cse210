class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int minutes, double distance)
        :base(date, minutes)
    {
        _distance = distance;
    }

    public override double Speed()
    {
        return _distance / _minutes * 60;
    }
    public override double Pace()
    {
        return _minutes / _distance;
    }
    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min): Distance {_distance} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
}