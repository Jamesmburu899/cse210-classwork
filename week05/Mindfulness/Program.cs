using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected int duration;
    
    public void Start()
    {
        Console.WriteLine($"Starting {this.GetType().Name}...");
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        Run();
        End();
    }

    protected abstract void Run();

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b|" ); Thread.Sleep(250);
            Console.Write("\b/" ); Thread.Sleep(250);
            Console.Write("\b-" ); Thread.Sleep(250);
            Console.Write("\b\\"); Thread.Sleep(250);
        }
        Console.WriteLine();
    }

    protected void End()
    {
        Console.WriteLine($"Great job! You completed {this.GetType().Name} for {duration} seconds.");
        ShowSpinner(3);
    }
}

class BreathingActivity : Activity
{
    protected override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.Write("Breathe out... ");
            ShowCountdown(3);
        }
    }
    
    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }
}

class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?"
    };

    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            ShowSpinner(5);
        }
    }
}

class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    protected override void Run()
    {
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine("You have 5 seconds to think...");
        ShowSpinner(5);
        Console.WriteLine("Start listing items (Press enter after each item, type 'done' to finish):");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
            }
            
            activity.Start();
        }
    }
}
