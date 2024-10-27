// SimpleGoal.cs
using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        isComplete = true;
        Console.WriteLine($"Completed {name}! You earned {points} points.");
    }

    public override string GetStatus() => isComplete ? "[X]" : "[ ]";

    public override string GetStringRepresentation() => $"SimpleGoal:{name},{points},{isComplete}";
}   
