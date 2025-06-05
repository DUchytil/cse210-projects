class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 32, "Gun");
        Console.WriteLine(myPoliceMan.GetPoliceManInformation()); //The GetPersonInformation() method is called and defined only in the base class

    }
}