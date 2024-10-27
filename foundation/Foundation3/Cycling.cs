using System;

public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int minutes, double speed) 
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed / 60) * GetMinutes(); // Distance in miles

    public override double GetSpeed() => _speed; // Speed in mph

    public override double GetPace() => 60 / _speed; // Pace in min/mile

    public override string GetSummary()
    {
        return $"{base.GetSummary()} miles (Cycling)";
    }
}
