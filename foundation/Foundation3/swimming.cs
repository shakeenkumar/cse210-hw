using System;

public class Swimming : Activity
{
    private int _laps; // number of laps

    public Swimming(DateTime date, int minutes, int laps) 
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50 / 1000.0); // Distance in km

    public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60; // Speed in kph

    public override double GetPace() => GetMinutes() / GetDistance(); // Pace in min/km

    public override string GetSummary()
    {
        return $"{base.GetSummary()} km (Swimming)";
    }
}
