using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {
        _name = "Breathing Activity";
        _description = "In this activity, you will employ box breathing, which is done by breathing in, holding it,\nreleasing the breath, and waiting before starting again.\n - Keep in mind each box takes 16 seconds and your duration will be rounded.";
    }

    public int Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Clear your mind and prepare to start...");
        DownFromThree();
        
        int boxes = 0;
        int timePassed = 0;
        if (_duration > 16)
        {
            if ((_duration % 16) >= 8)
            {
                do {
                    Console.Write("\nBreath in  ");
                    DotDotDot();
                    Console.Write("\nNow hold   ");
                    DotDotDot();
                    Console.Write("\nBreath Out ");
                    DotDotDot();
                    Console.Write("\nNow hold   ");
                    DotDotDot();
                    Console.Write("\n");
                    boxes += 1;
                    timePassed += 16;
                } while (timePassed < _duration);
            }
            else 
            {
                _duration -= (_duration % 16);
                do {
                    Console.Write("\nBreath in  ");
                    DotDotDot();
                    Console.Write("\nNow hold   ");
                    DotDotDot();
                    Console.Write("\nBreath Out ");
                    DotDotDot();
                    Console.Write("\nNow hold   ");
                    DotDotDot();
                    Console.Write("\n");
                    boxes += 1;
                    timePassed += 16;
                } while (timePassed < _duration);
            }
        }
        else 
        {    
            do {
                Console.Write("\nBreath in  ");
                DotDotDot();
                Console.Write("\nNow hold   ");
                DotDotDot();
                Console.Write("\nBreath Out ");
                DotDotDot();
                Console.Write("\nNow hold   ");
                DotDotDot();
                Console.Write("\n");
                boxes += 1;
                timePassed += 16;
            } while (timePassed < _duration);
        }

        _duration = timePassed;
        DisplayEndingMessage();
        return boxes;
    }
}