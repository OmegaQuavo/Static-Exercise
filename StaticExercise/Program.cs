using System;

class Program
{
    static void Main(string[] args)
    {
        double tempF = 98.6;
        double tempC = 37;

        double resultC = TempConverter.FahrenheitToCelsius(tempF);
        double resultF = TempConverter.CelsiusToFahrenheit(tempC);

        Console.WriteLine($"{tempF}°F in Celsius is {resultC:F2}°C");
        Console.WriteLine($"{tempC}°C in Fahrenheit is {resultF:F2}°F");
    }
}