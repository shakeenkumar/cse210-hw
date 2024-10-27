// Goal.cs
using System;

public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool isComplete;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        this.isComplete = false;
    }

    public string GetName() => name;

    public int GetPoints() => points;

    public bool IsComplete() => isComplete;

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();
}
