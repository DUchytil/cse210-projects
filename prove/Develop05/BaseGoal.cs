class BaseGoal
{
    int _pointValue;
    string _goalName;
    string _goalDescription;

    bool _isCompleted = false;

    public BaseGoal()
    {
        setGoalInfo();
    }

    public void setGoalInfo()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string input = Console.ReadLine();
        _pointValue = int.Parse(input);
    }

    public int getGoalPoints()
    {
        return _pointValue;
    }

    public virtual string getGoalInfoToPrint()
    {
        return $"{_goalName} ({_goalDescription})";
    }
}