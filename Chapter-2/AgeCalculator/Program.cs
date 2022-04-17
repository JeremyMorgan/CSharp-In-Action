using System;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();

            if (name != null && name.Length > 0){         

                Console.WriteLine($"Hello {name}, the time is {date:hh:mm}");

                    Console.WriteLine("Hello {0}! Enter your birthday Month (1-12):", name);
                    var month = Console.ReadLine();

                    Console.WriteLine("Enter the Day:");
                    var day = Console.ReadLine();

                    Console.WriteLine("Enter the Year:");
                    var year = Console.ReadLine();

                    Console.WriteLine("Your Birthday is {0}", (month + "-" + day + "-" + year));

                    int y = Convert.ToInt16(year);
                    int m = Convert.ToInt16(month);
                    int d = Convert.ToInt16(day);
                    DateTime birthday = new DateTime(y, m, d);

                    DateTime now = DateTime.Now;

                    TimeSpan result = now.Subtract(birthday);

                    Console.WriteLine("You've been alive for:");
                    Console.WriteLine("{0} days", result.TotalDays);
                    Console.WriteLine("{0} Hours", result.TotalHours);
                    Console.WriteLine("{0} Minutes", result.TotalMinutes);
                    Console.WriteLine("{0} Seconds", result.TotalSeconds);

            }else {
                Console.WriteLine("You must enter a name");
            }
        }
    }
}