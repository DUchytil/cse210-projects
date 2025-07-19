class EternalGoal : BaseGoal
{
    public EternalGoal(bool previouslyPopulated = false) : base(previouslyPopulated)
    {
        _goalType = "EternalGoal";
    }

    public override string packageInfoForFile()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_pointValue}|{_isCompleted}";
    }
    public override void processCompletion()
    {
        _isCompleted = false; // Eternal goals are never completed, so we set it to false
    }

}
