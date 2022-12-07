// See https://aka.ms/new-console-template for more information

var date = DateTime.Now;

Console.WriteLine("What is your name?");

var name = Console.ReadLine();

Console.WriteLine($"Hello {name}, the time is {date:hh:mm}");