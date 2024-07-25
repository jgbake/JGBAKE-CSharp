using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager thisRun = new GoalManager();
        bool endCase = false;
        do {
            thisRun.DisplayMenu();
        } while (endCase != true);
    }
}