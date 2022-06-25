class Program
{
    public delegate void LogHandler(string message); 

    public static void Main()
    {
        // delegate instance
        LogHandler LogA = new LogHandler(LogToText);
        LogHandler LogB = new LogHandler(LogToDatabase);

        LogA += LogB;

        int[] ourNumbers = new int[] { 22, 42, 37, 44, 100 };

        foreach (var number in ourNumbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even", number);
            }
            else 
            {
                LogA("Odd Number Found, Discarding");
            }            
        }
    }

    public static void LogToText(string message)
    {
        Console.WriteLine("Writing to text file:\n" + message);
    }

    public static void LogToDatabase(string message)
    {
        Console.WriteLine("Writing to database:\n" + message);
    }
}