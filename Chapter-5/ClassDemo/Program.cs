﻿internal class Program
{
    private static void Main(string[] args)
    {

        var customer1 = new Customer{ FirstName = "John", LastName = "Smith" };
        var customer2 = new Customer{ FirstName = "Jill", LastName = "Jones" };
        var customer3 = new Customer();
    
        Console.WriteLine("Hello " + customer1.FirstName + " " + customer1.LastName);

        Console.WriteLine("Done");
    }
}

public class Customer {

    public string FirstName { get; init; } 
    public string LastName { get; init; }

    public Customer() {
        Console.WriteLine("Customer object created");
    }

    // conventional constructor
    public Customer(String firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    } 
}


// public class Customer {

//     public string FirstName { get; set; } = default!;
//     public string LastName { get; set; } = default!;

//     public Customer() {
//         Console.WriteLine("Customer object created");
//     }

//     // destructor 
//     ~Customer() {
//         Console.WriteLine("Customer object destroyed");
//     }

//     // conventional constructor
//     public Customer(String firstName, string lastName)
//     {
//         FirstName = firstName;
//         LastName = lastName;
//     }  

// }


// define the fields on your own


/*
public class Customer {

    private string _firstname;

    public string FirstName { 
        get { 
            return _firstname;
        }
        set {
            _firstname = value.ToUpperInvariant();
        }
    }
    public string LastName { get; set; } = default!;

    public Customer() {}

    public Customer(String firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}
*/