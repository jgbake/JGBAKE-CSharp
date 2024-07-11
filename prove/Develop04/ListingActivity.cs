using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        base._name = "Listing Activity";
        base._description = "In this activity you will make a list of responses based on prompts, to help you \nrecognize the good parts of your life.";
        _prompts = new List<string>() {
            "When have you felt the spirit this week?\n",
            "List some things you enjoyed about the past couple of days.\n",
            "What do you think some of your strengths are?\n",
            "Who do you admire or appreciate?\n",
            "What are some of the best meals you've eaten recently?\n",
            "If you could meet with some of your heroes, who would you choose?\n",
            "When are some times that you've felt good about doing something for someone else?\n"
        };
    }

    public int Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Clear your mind and prepare to start...");
        Random randPrompt = new Random();
        Console.Write("Your prompt is:\n" + _prompts[randPrompt.Next(0, _prompts.Count)]);
        DownFromThree();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(" > ");
            Console.ReadLine();
            _count += 1;
        }
        DisplayEndingMessage();
        return _count;
    }
}