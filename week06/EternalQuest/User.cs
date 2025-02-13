public class User
{
    public string Name { get; set; }
    public int Score { get; set; }
    public List<Goal> Goals { get; set; }

    public User(string name)
    {
        Name = name;
        Score = 0;
        Goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void DisplayGoals()
    {
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }
}
