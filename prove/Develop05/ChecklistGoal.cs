class ChecklistGoal : BaseGoal
{
    private int _completionBonus;
    private int _completionGoalForBonus;
    private int _timesCompleted = 0;
    public ChecklistGoal(bool previouslyPopulated = false) : base(previouslyPopulated)
    {
        _goalType = "ChecklistGoal";
    }

    public override string PackageInfoForFile()
    {
        return $"{_goalType}|{_goalName}|{_goalDescription}|{_pointValue}|{_completionBonus}|{_completionGoalForBonus}|{_timesCompleted}";
    }

    public override void ProcessCompletion()
    {
        _timesCompleted++;
        if (_timesCompleted >= _completionGoalForBonus)
        {
            _isCompleted = true;
            return;
        }
        _isCompleted = false;
    }

    public override void LoadInfo(string name = "default name", string description = "default description", int pointValue = 0, bool isCompleted = false, int completionBonus = 0, int completionGoal = 0, int timesCompleted = 0)
    {
        _goalName = name;
        _goalDescription = description;
        _pointValue = pointValue;
        _completionBonus = completionBonus;
        _completionGoalForBonus = completionGoal;
        _timesCompleted = timesCompleted;
    }

    public override void SetGoalInfo()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _completionGoalForBonus = int.Parse(Console.ReadLine());
        Console.Write($"What is the bonus for accomplishing it {_completionGoalForBonus} time(s)? ");
        _completionBonus = int.Parse(Console.ReadLine());
    }

    public override string GetGoalInfoToPrint()
    {
        return $"{_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_completionGoalForBonus}";
    }

    public override int GetGoalPoints()
    {
        if (_isCompleted)
        {
            return _pointValue + _completionBonus;
        }
        return _pointValue;
    }

}
