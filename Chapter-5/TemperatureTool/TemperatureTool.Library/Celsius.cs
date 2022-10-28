internal class Celsius
{
    private float _inputTempf;
    private float _temp;

    public float ConvertToCelsius(float tempf)
    {   
        _inputTempf = tempf;
        _temp = _inputTempf - 32;

        return _temp * 5 / 9;
    }
}