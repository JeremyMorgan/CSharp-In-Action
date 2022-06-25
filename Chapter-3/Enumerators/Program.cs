var today = DayOfWeek.Monday;

if (today == DayOfWeek.Monday){

    Console.WriteLine("It sure is Monday! Get to work!");
}

DateTime todaysDate = DateTime.Today;

Console.WriteLine(todaysDate.DayOfWeek);

enum DayOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
}
