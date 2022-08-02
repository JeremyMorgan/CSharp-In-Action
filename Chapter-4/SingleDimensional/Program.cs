// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// initialize a blank array 
//int[] ourNumbers = new int[8];

// initialize an array of values 
int[] ourNumbers = new int[] { 2, 4, 6, 8, 10, 12};

ourNumbers[3] = 45;

for (int i = 0; i < ourNumbers.Length; i++)
{
    Console.WriteLine(ourNumbers[i]);
}

// string array initialization
//var ourNames = new string[] { "John", "Paul", "George", "Ringo" };

// int array initialization
//int[] array1 = { 1, 2, 3, 4, 5};

string[] names = { "John", "Paul", "George", "Ringo" };

Console.WriteLine($"Length of names is {names.Length}");

// throws Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
//Console.WriteLine($"The last name in the list is {names[4]}");

Console.WriteLine($"The last name in the list is {names[names.Length -1]}");