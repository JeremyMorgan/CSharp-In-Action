var ourPerson = new Person("Jack");

Console.WriteLine($"Hello {ourPerson.GetFirstName()}");

interface ICustomer {
    string GetFirstName();
    void ChangeName(string FirstName);
}


class Person : ICustomer {
  
    private string _firstName { get; set; }

    public Person(string FirstName)
    {
        _firstName = FirstName;
    }

    public string GetFirstName() {
        return _firstName;
    }

    public void ChangeName(string FirstName){
        _firstName = FirstName;
    }
}
