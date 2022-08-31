using System;

namespace temperature_change
{
    internal class Program
    {
        static void Main()
        {
            // Prompt user to enter a temperature in Fahrenheit
            Console.Write("Enter a temperature in Fahrenheit: ");

            var temperaturePrompt = Console.ReadLine();

            // Check if entered values is a number
            float InputTemperature;
            while (!float.TryParse(temperaturePrompt, out InputTemperature))
            {
                Console.Write("This is not a number! Please enter a temperature in Fahrenheit: ");
                temperaturePrompt = Console.ReadLine();
            }

            // Calculate input value to Celsius
            var temp = new Temperatures();
            float OutputTemperature = temp.FahrenheitToCelsius(InputTemperature);

            // Return the result
            Console.WriteLine();
            Console.WriteLine($"{InputTemperature} degrees in Fahrenheit is equal to {OutputTemperature} degrees in Celsius ");
        }
    }
    internal class Temperatures
    {
        public float FahrenheitToCelsius(float InputTemperature)
        {
            return (InputTemperature - 32) * 5 / 9;
        }
    }
}
