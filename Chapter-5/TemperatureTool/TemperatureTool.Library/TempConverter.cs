public class TempConverter
{
    public float TemperatureF {get; set; }
    public float TemperatureC {get; set; }

    public void ConvertToCelsius(float temp)
    {
        Celsius celsiusConverter = new Celsius();
        TemperatureC = celsiusConverter.ConvertToCelsius(temp);
    }
    public void ConvertToFahrenhiet(float temp)
    {
        Fahrenheit fahrenheitConverter = new Fahrenheit();
        TemperatureF = fahrenheitConverter.ConvertToFahrenheit(temp);
    }
}
