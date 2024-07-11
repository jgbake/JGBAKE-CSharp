using System;
using System.Security;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "In this activity you will reflect on a time in your life which showed your strength.\nThis will help you to realize your abilities and harden your resolve, and requires at least 24 seconds to complete";
        _prompts = new List<string>() {
            "stood up for another.",
            "completed a challenging task.",
            "did something you're proud of.",
            "were able to help someone else complete a task.",
            "helped someone in a bad situation.",
            "succeeded where you first though you'd fail."
        };
        _questions = new List<string>() {
            "Why do you think this moment came to mind?",
            "How did you feel after it was over?",
            "What about that moment stands out the most?",
            "What went through your mind as it was happening?",
            "Have you had other similar experiences?",
            "What set this moment apart from others like it?",
            "Do you think you could apply what happened to your life now?",
            "Have you ever wished you might experience a similar moment again?",
            "What do you think caused you to succeed here, where you might have failed before?",
            "How do you think that moment affected your life?"
        };
    }

    private void PromptAndQuestionDisplay(Random randPrompt, Random randQuestions, float time1, float time2)
    {
        Console.Write("\nThink of a time when you " + _prompts[randPrompt.Next(0, _prompts.Count)]);
        Spinner(time1);
        Console.Write("\n > " + _questions[randQuestions.Next(0, _questions.Count)] + " ");
        Spinner(time2);
        Console.Write("\n > " + _questions[randQuestions.Next(0, _questions.Count)] + " ");
        Spinner(time2);
        Console.Write("\n");
    }

    public int Run()
    {
        DisplayStartingMessage();
        Random randPrompt = new Random();
        Random randQuestions = new Random();
        if (_duration < 24) 
        {
            Console.Clear();
            Console.Write("\nSorry, you inputted too low of a duration and can try again in ");
            DownFromThree();
            return 0;
        }
        else if ((_duration >= 24) && (_duration < 36))
        {
            Console.WriteLine("Clear your mind and prepare to start...");
            DownFromThree();
            PromptAndQuestionDisplay(randPrompt, randQuestions, (_duration * (float)0.4), (_duration * (float)0.3));
            DisplayEndingMessage();
            return 2;
        }
        else if ((_duration >= 36) && (_duration < 64))
        {
            Console.WriteLine("Clear your mind and prepare to start...");
            DownFromThree();
            PromptAndQuestionDisplay(randPrompt, randQuestions, (_duration * (float)0.2), (_duration * (float)0.15));
            PromptAndQuestionDisplay(randPrompt, randQuestions, (_duration * (float)0.2), (_duration * (float)0.15));
            DisplayEndingMessage();
            return 4;
        }
        else if (_duration >= 64)
        {
            Console.WriteLine("Clear your mind and prepare to start...");
            DownFromThree();
            int reflections = 0;
            int promptCount = (int)Math.Round((float)(_duration / 28));
            float individualDuration = _duration / promptCount;
            while (promptCount >= 1)
            {
                PromptAndQuestionDisplay(randPrompt, randQuestions, (individualDuration * (float)0.42), (individualDuration * (float)0.29));
                promptCount -= 1;
            }
            reflections += (int)(promptCount * 2);

            DisplayEndingMessage();
            return reflections;
        }
        else 
        {
            Console.WriteLine("Uh oh... Something weird happened...");
            return 0;
        }
    }
}