internal class Fahrenheit
{
    private float _inputTempc;
    private float _temp;

    public float ConvertToFahrenheit(float tempc)
    {
        _inputTempc = tempc;
        _temp = _inputTempc * 9 / 5;
        return _temp + 32;
    }
}