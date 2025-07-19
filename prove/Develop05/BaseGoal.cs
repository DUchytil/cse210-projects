
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
            setGoalInfo();
        }
    }

    public virtual void setGoalInfo()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string input = Console.ReadLine();
        _pointValue = int.Parse(input);
    }

    public virtual int getGoalPoints()
    {
        return _pointValue;
    }  

    public virtual string getGoalInfoToPrint()
    {
        return $"{_goalName} ({_goalDescription})";
    }

    public virtual void setAsCompleted()
    {
        _isCompleted = true;
    }

    public string getCompletionIndicator()
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
    public string getGoalName()
    {
        return _goalName;
    }

    public abstract string packageInfoForFile();
    public virtual void loadInfo(string name = "default name", string description = "default description", int pointValue = 0, bool isCompleted = false, int completionBonus = 0, int completionGoal = 0, int timesCompleted = 0)
    {
        _goalName = name;
        _goalDescription = description;
        _pointValue = pointValue;
        _isCompleted = isCompleted;
    }
    public string getGoalType()
    {
        return _goalType;
    }
    public virtual void processCompletion()
    {
        _isCompleted = true;
    }
}