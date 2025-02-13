public class ChecklistGoal : Goal
{
    public int TimesToComplete { get; set; }
    public int TimesCompleted { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string title, string description, int points, int timesToComplete, int bonusPoints)
        : base(title, description, points)
    {
        TimesToComplete = timesToComplete;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }

    public override void RecordProgress(User user)
    {
        if (TimesCompleted < TimesToComplete)
        {
            TimesCompleted++;
            user.Score += Points;

            if (TimesCompleted == TimesToComplete)
            {
                user.Score += BonusPoints;
                IsCompleted = true;
            }
        }
    }

    public override string GetGoalStatus()
    {
        return $"{TimesCompleted}/{TimesToComplete} Completed";
    }
}
