using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),     // 3 miles
            new Cycling(new DateTime(2022, 11, 4), 30, 12.0),    // 12 mph
            new Swimming(new DateTime(2022, 11, 5), 30, 20)      // 20 laps
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
