using System;

public class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int GetMinutes() => _minutes;

    public virtual double GetDistance() => 0; // To be overridden
    public virtual double GetSpeed() => 0;    // To be overridden
    public virtual double GetPace() => 0;     // To be overridden

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Activity ({_minutes} min) - Distance: {GetDistance():0.0}, Speed: {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}
