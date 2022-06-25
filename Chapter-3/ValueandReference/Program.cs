using System.Globalization;

// create an integer
int i = 37; 

// display the value
Console.WriteLine("The value of i is {0}", i);

// create another integer from i 
int i2 = i;

// change the value 
i2 = 42;

// write out the new value 
Console.WriteLine("The value of i2 is {0}", i2);

// create a new person object
Person p = new Person("Jeremy");

// write out the value
Console.WriteLine("The value of p is {0}", p.GetFirstName());

// create a copy of person
var p2 = p;

// write out that value
Console.WriteLine("The value of p2 is {0}", p2.GetFirstName());

// change the name
p2.ChangeName("Fred");

// write out the value of the original object
Console.WriteLine("The value of p is {0}", p.GetFirstName());

// write out the value of the copied object 
Console.WriteLine("The value of p2 is {0}", p2.GetFirstName());

class Person 
{  
    private string _firstName;

    public Person(string FirstName)
    {
        _firstName = FirstName;
    }

    public string GetFirstName() 
    {
        return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(_firstName.ToLower());
    }

    public void ChangeName(string FirstName)
    {
        _firstName = FirstName;
    }
}