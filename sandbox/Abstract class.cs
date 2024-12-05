using System;

public abstract class SmartDevice
{
    public string Name { get; set; }
    public bool IsOn { get; private set; }
    private DateTime? TurnedOnAt { get; set; }

    protected SmartDevice(string name)
    {
        Name = name;
        IsOn = false;
    }

    public void TurnOn()
    {
        if (!IsOn)
        {
            IsOn = true;
            TurnedOnAt = DateTime.Now;
            Console.WriteLine($"{Name} is now ON.");
        }
    }

    public void TurnOff()
    {
        if (IsOn)
        {
            IsOn = false;
            TurnedOnAt = null;
            Console.WriteLine($"{Name} is now OFF.");
        }
    }

    public string GetStatus() => $"{Name} is {(IsOn ? "ON" : "OFF")}.";

    public TimeSpan? GetTimeOn()
    {
        if (IsOn && TurnedOnAt.HasValue)
            return DateTime.Now - TurnedOnAt;
        return null;
    }
}
