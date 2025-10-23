public static class TempConverter
{
    // Converts Fahrenheit to Celsius
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Converts Celsius to Fahrenheit
    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}