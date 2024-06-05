class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int minutes, double speed)
        :base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return _speed / 60 * _minutes;
    }
    public override double Pace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min): Distance {Distance()} km, Speed: {_speed} kph, Pace: {Pace()} min per km";
    }
}