// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.LoadGoals("goals.txt"); // Load goals from file

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter goal type (simple, eternal, checklist):");
                string goalType = Console.ReadLine();

                Console.WriteLine("Enter goal name:");
                string goalName = Console.ReadLine();

                Console.WriteLine("Enter points for the goal:");
                int points = int.Parse(Console.ReadLine());

                if (goalType.ToLower() == "simple")
                {
                    manager.AddGoal(new SimpleGoal(goalName, points));
                }
                else if (goalType.ToLower() == "eternal")
                {
                    manager.AddGoal(new EternalGoal(goalName, points));
                }
                else if (goalType.ToLower() == "checklist")
                {
                    Console.WriteLine("Enter required times:");
                    int requiredTimes = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter bonus points:");
                    int bonusPoints = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(goalName, points, requiredTimes, bonusPoints));
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter the name of the goal to record an event:");
                string goalName = Console.ReadLine();
                manager.RecordEvent(goalName);
            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
            }
            else if (choice == "4")
            {
                manager.SaveGoals("goals.txt"); // Save goals to file
                Console.WriteLine("Goals saved.");
            }
            else if (choice == "5")
            {
                break;
            }
        }
    }
}
