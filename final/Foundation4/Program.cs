using System;
using System.Collections.Generic;
using FitnessTracker;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2023, 11, 4), 45, 15.0),
            new Swimming(new DateTime(2023, 11, 5), 60, 20)
        };
        {
            Console.WriteLine("Activity List:");
        }

        foreach (var activity in activities)
        {
            
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
