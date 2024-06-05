abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double Distance()
    {
        return Speed() / 60 * _minutes;
    }
    public virtual double Speed()
    {
        return Distance() / _minutes * 60;
    }
    public virtual double Pace()
    {
        return 60 / Speed();
    }
    public abstract string GetSummary();
}