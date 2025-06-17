using System.Net;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 32, "Gun");
        Console.WriteLine(myPoliceMan.GetPoliceManInformation()); //The GetPersonInformation() method is called and defined only in the base class

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myPoliceMan);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }

    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
    }
}