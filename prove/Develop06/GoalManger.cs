// GoalManager.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (var goal in goals)
        {
            if (goal.GetName() == goalName)
            {
                goal.RecordEvent();
                if (goal.IsComplete())
                {
                    totalScore += goal.GetPoints();
                }
                else
                {
                    totalScore += goal.GetPoints();
                }
                Console.WriteLine($"Total Score: {totalScore}");
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.GetName()}");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split(':');
                if (parts[0] == "SimpleGoal")
                {
                    string[] details = parts[1].Split(',');
                    goals.Add(new SimpleGoal(details[0], int.Parse(details[1])));
                }
                else if (parts[0] == "EternalGoal")
                {
                    string[] details = parts[1].Split(',');
                    goals.Add(new EternalGoal(details[0], int.Parse(details[1])));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    string[] details = parts[1].Split(',');
                    goals.Add(new ChecklistGoal(details[0], int.Parse(details[1]), int.Parse(details[3]), int.Parse(details[4])));
                }
            }
        }
    }
}
