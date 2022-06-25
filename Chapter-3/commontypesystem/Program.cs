// Classes section 
/*


// implicit declaration
var p = new Person("Jeremy");

// explicit declaration
Person p = new Person("Jeremy");


class Person {

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
*/

// structs section 

/*
var p = new Person();

p.firstName = "Jeremy";
p.ID = 2;

Person p2 = p;

p2.firstName = "Amber";
p2.ID = 3;

Console.WriteLine("First name of p is {0} and ID is {1}", p.firstName, p.ID.ToString());
Console.WriteLine("First name of p2 is {0} and ID is {1}", p2.firstName, p2.ID.ToString());


struct Person {
    public int ID;
    public string firstName;
}

*/
