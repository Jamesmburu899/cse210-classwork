using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> Prompts { get; set; }

    public PromptGenerator()
    {
        Prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I learn today?",
            "What made me smile today?",
            "What am I grateful for today?",
            "What challenges did I face today?",
            "What are my goals for tomorrow?"
        };
    }

    // Get a random prompt
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(Prompts.Count);
        return Prompts[index];
    }
    
    public void AddCustomPrompt(string prompt)
    {
        Prompts.Add(prompt);
        Console.WriteLine("Custom prompt added successfully.");
    }
}
