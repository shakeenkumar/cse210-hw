// ChecklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int timesCompleted;
    private int requiredTimes;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int requiredTimes, int bonusPoints) : base(name, points)
    {
        this.requiredTimes = requiredTimes;
        this.bonusPoints = bonusPoints;
        this.timesCompleted = 0;
    }

    public override void RecordEvent()
    {
        timesCompleted++;
        Console.WriteLine($"Recorded event for {name}. Earned {points} points!");

        if (timesCompleted >= requiredTimes)
        {
            isComplete = true;
            Console.WriteLine($"Congratulations! You completed {name} and earned an additional {bonusPoints} points!");
        }
    }

    public override string GetStatus() => isComplete ? $"[X] Completed {timesCompleted}/{requiredTimes}" : $"[ ] Completed {timesCompleted}/{requiredTimes}";

    public override string GetStringRepresentation() => $"ChecklistGoal:{name},{points},{timesCompleted},{requiredTimes},{bonusPoints},{isComplete}";
}
