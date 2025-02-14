using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nExercise Tracking Program");
                Console.WriteLine("1. Add Running Activity");
                Console.WriteLine("2. Add Cycling Activity");
                Console.WriteLine("3. Add Swimming Activity");
                Console.WriteLine("4. View Activity Summaries");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddRunningActivity(activities);
                        break;
                    case "2":
                        AddCyclingActivity(activities);
                        break;
                    case "3":
                        AddSwimmingActivity(activities);
                        break;
                    case "4":
                        ViewActivitySummaries(activities);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddRunningActivity(List<Activity> activities)
        {
            Console.Write("Enter the date (MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the length in minutes: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the distance in miles: ");
            double distance = double.Parse(Console.ReadLine());

            activities.Add(new Running(date, length, distance));
            Console.WriteLine("Running activity added successfully!");
        }

        static void AddCyclingActivity(List<Activity> activities)
        {
            Console.Write("Enter the date (MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the length in minutes: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the speed in mph: ");
            double speed = double.Parse(Console.ReadLine());

            activities.Add(new Cycling(date, length, speed));
            Console.WriteLine("Cycling activity added successfully!");
        }

        static void AddSwimmingActivity(List<Activity> activities)
        {
            Console.Write("Enter the date (MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the length in minutes: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of laps: ");
            int laps = int.Parse(Console.ReadLine());

            activities.Add(new Swimming(date, length, laps));
            Console.WriteLine("Swimming activity added successfully!");
        }

        static void ViewActivitySummaries(List<Activity> activities)
        {
            if (activities.Count == 0)
            {
                Console.WriteLine("No activities found. Please add activities first.");
                return;
            }

            Console.WriteLine("\nActivity Summaries:");
            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine($"  - Distance: {activity.GetDistance():F1} miles / {activity.GetDistance() * 1.60934:F1} km");
                Console.WriteLine($"  - Speed: {activity.GetSpeed():F1} mph / {activity.GetSpeed() * 1.60934:F1} kph");
                Console.WriteLine($"  - Pace: {activity.GetPace():F1} min/mile / {activity.GetPace() / 1.60934:F1} min/km");
                Console.WriteLine();
            }
        }
    }
}