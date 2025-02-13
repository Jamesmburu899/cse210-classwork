public class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points)
        : base(title, description, points) { }

    public override void RecordProgress(User user)
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            user.Score += Points;
        }
    }
}
