class SimpleGoal : BaseGoal
{
    public SimpleGoal(bool previouslyPopulated = false) : base(previouslyPopulated)
    {
        _goalType = "SimpleGoal";
    }

    public override string packageInfoForFile()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_pointValue}|{_isCompleted}";
    }
}