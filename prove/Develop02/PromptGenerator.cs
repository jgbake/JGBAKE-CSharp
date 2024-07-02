using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomPromptIndex = new Random();
        int promptIndex = randomPromptIndex.Next(0,(_prompts.Count));
        return _prompts[promptIndex];
    }
}