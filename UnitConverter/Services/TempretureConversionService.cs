using UnitConverter.Models;

namespace UnitConverter.Services
{
    public class TempretureConversionService
    {
        public double ConvertTemperature(double value, TemperatureUnit from, TemperatureUnit to)
        {
            if (from == to) return value;

            return from switch
            {
                TemperatureUnit.Celsius when to == TemperatureUnit.Fahrenheit => (value * 9 / 5) + 32,
                TemperatureUnit.Celsius when to == TemperatureUnit.Kelvin => value + 273.15,
                TemperatureUnit.Fahrenheit when to == TemperatureUnit.Celsius => (value - 32) * 5 / 9,
                TemperatureUnit.Fahrenheit when to == TemperatureUnit.Kelvin => (value - 32) * 5 / 9 + 273.15,
                TemperatureUnit.Kelvin when to == TemperatureUnit.Celsius => value - 273.15,
                TemperatureUnit.Kelvin when to == TemperatureUnit.Fahrenheit => (value - 273.15) * 9 / 5 + 32,
                _ => throw new ArgumentException("Invalid temperature conversion"),

            };
        }
    }
}
