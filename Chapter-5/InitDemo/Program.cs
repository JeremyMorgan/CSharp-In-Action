internal partial class Program
{
    private static void Main(string[] args)
    {
        var customer1 = new Customer{ FirstName = "John", LastName = "Smith" };
    
        Console.WriteLine("Hello " + customer1.FirstName + " " + customer1.LastName);

        customer1.FirstName = "Bill";
    }
}

public class Customer 
{
    public string? FirstName { get; init; } 
    public string? LastName { get; init; }
}
