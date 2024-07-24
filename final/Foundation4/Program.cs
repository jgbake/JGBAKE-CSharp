using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        List<Activity> activities = new List<Activity>{
            new Running((float)4.5, today, (float)42.5),
            new Cycling((float)10.5, today, 60),
            new Swimming(25, today, 60),
            new Running((float)8.25, today, 40),
            new Cycling(11, today, (float)45.5),
            new Swimming(72, today, 90),
            new Running(3, today, 30),
            new Cycling(12, today, 30),
            new Swimming(50, today, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}