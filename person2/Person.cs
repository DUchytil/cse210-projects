using System.Data;

class Person
{
    private string _firstname;
    private string _lastName;
    private int _age;

    public Person()
    {
        _firstname = "";
        _lastName = "";
        _age = 0;
    }

    public Person(string firstName, string lastName, int age)
    {
        _firstname = firstName;
        _lastName = lastName;
        _age = age;
    }

    public string GetPersonInformation()
    {
        return $"{_firstname} {_lastName} age: {_age}";
    }
}