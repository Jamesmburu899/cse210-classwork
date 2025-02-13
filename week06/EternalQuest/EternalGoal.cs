public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points)
        : base(title, description, points) { }

    public override void RecordProgress(User user)
    {
        if (!IsCompleted)
        {
            user.Score += Points;
        }
    }

    public override string GetGoalStatus()
    {
        return "[Eternal] - Progress Recorded";
    }
}
