
abstract class BaseGoal
{
    protected int _pointValue;
    protected string _goalName;
    protected string _goalDescription;
    protected bool _isCompleted = false;
    protected string _goalType;

    public BaseGoal(bool previouslyPopulated = false)
    {
        if (!previouslyPopulated)
        {
            SetGoalInfo();
        }
    }

    public virtual void SetGoalInfo()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string input = Console.ReadLine();
        _pointValue = int.Parse(input);
    }

    public virtual int GetGoalPoints()
    {
        return _pointValue;
    }

    public virtual string GetGoalInfoToPrint()
    {
        return $"{_goalName} ({_goalDescription})";
    }

    public virtual void SetAsCompleted()
    {
        _isCompleted = true;
    }

    public string GetCompletionIndicator()
    {
        if (_isCompleted)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    public string GetGoalName()
    {
        return _goalName;
    }

    public abstract string PackageInfoForFile();
    public virtual void LoadInfo(string name = "default name", string description = "default description", int pointValue = 0, bool isCompleted = false, int completionBonus = 0, int completionGoal = 0, int timesCompleted = 0)
    {
        _goalName = name;
        _goalDescription = description;
        _pointValue = pointValue;
        _isCompleted = isCompleted;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public virtual void ProcessCompletion()
    {
        _isCompleted = true;
    }
    
    public bool IsCompleted()
    {
        return _isCompleted;
    }
}