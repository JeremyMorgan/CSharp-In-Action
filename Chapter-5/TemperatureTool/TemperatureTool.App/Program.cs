internal class Program
{
    private static void Main(string[] args)
    {
        var tempConverter = new TempConverter();

        tempConverter.ConvertToCelsius(80);

        Console.WriteLine("80f is " + tempConverter.TemperatureC + " Celsius");

        tempConverter.ConvertToFahrenhiet(24);

        Console.WriteLine("24c is " + tempConverter.TemperatureF + " Fahrenheit");
    }
}