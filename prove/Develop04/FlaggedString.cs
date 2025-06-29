class FlaggedString
{
    private string _string;
    private bool _usedStatus;

    public FlaggedString(string stringInput)
    {
        _string = stringInput;
        _usedStatus = false;
    }

    public bool GetUsedStatus()
    {
        return _usedStatus;
    }

    public string GetString()
    {
        _usedStatus = true; //Automatically sets string status as used when this function is called.
        return _string;
    }

    public void SetStringAsUsed(bool wasUsed)
    {
        _usedStatus = true;
    }

    public void ResetStringStatus()
    {
        _usedStatus = false;
    }

}