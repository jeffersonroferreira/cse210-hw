using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running("2 Nov 22", 45, 3);
        Swimming swimming = new Swimming("3 Dec 14", 60, 50);
        Cycling cycling = new Cycling("4 Jan 24", 60, 1.0);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);
        
        foreach (Activity activity in activities)
        {
            Console.Clear();
            activity.GetSummary();
            Console.Write("\nPress Enter to Continue");
            Console.ReadLine();
        }
    }
}