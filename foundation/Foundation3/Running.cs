using System;

public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int minutes, double distance) 
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetMinutes()) * 60; // Speed in mph

    public override double GetPace() => GetMinutes() / _distance; // Pace in min/mile

    public override string GetSummary()
    {
        return $"{base.GetSummary()} miles (Running)";
    }
}
