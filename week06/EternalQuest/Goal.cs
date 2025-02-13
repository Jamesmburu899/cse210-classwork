public abstract class Goal
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public bool IsCompleted { get; set; }

    public Goal(string title, string description, int points)
    {
        Title = title;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordProgress(User user);

    public virtual string GetGoalStatus()
    {
        return IsCompleted ? "[X] Completed" : "[ ] Not Completed";
    }

    public override string ToString()
    {
        return $"{Title}: {Description} ({GetGoalStatus()})";
    }
}
