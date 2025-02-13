public class GoalManager
{
    public User CurrentUser { get; set; }

    public GoalManager(User user)
    {
        CurrentUser = user;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter the type of goal (Simple, Eternal, Checklist): ");
        string goalType = Console.ReadLine();

        Console.WriteLine("Enter the goal title: ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType.ToLower() == "simple")
        {
            CurrentUser.AddGoal(new SimpleGoal(title, description, points));
        }
        else if (goalType.ToLower() == "eternal")
        {
            CurrentUser.AddGoal(new EternalGoal(title, description, points));
        }
        else if (goalType.ToLower() == "checklist")
        {
            Console.WriteLine("Enter the number of times to complete the goal: ");
            int timesToComplete = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus points for completing the checklist: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            CurrentUser.AddGoal(new ChecklistGoal(title, description, points, timesToComplete, bonusPoints));
        }
    }

    public void RecordGoalProgress()
    {
        Console.WriteLine("Which goal would you like to record progress for? Enter the number: ");
        for (int i = 0; i < CurrentUser.Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {CurrentUser.Goals[i].Title}");
        }

        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < CurrentUser.Goals.Count)
        {
            CurrentUser.Goals[goalIndex].RecordProgress(CurrentUser);
            Console.WriteLine($"Goal Progress Recorded. Current Score: {CurrentUser.Score}");
        }
    }

    public void SaveData()
    {
        // Implement Save logic
    }

    public void LoadData()
    {
        // Implement Load logic
    }
}
