// EternalGoal.cs
using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {points} points for {name}!");
    }

    public override string GetStatus() => "[Eternal]";

    public override string GetStringRepresentation() => $"EternalGoal:{name},{points}";
}
