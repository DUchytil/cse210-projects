class PoliceMan : Person
{
    private string _weapons;
    public PoliceMan(string firstName, string lastName, int age, string weapons) : base(firstName, lastName, age) // This is immediately passing in all arguments into the bast class constructor with the exception of weapons which is specific to the the PoliceMan class.
    {
        _weapons = weapons;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}"; //Can also say base.GetPersonInformation(). "base" is a keyword that references the base class. 
    }
}