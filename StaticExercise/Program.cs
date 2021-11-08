using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter degree to be converted from Celcius to Fahrenheit:");
            var input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter degree to be converted from Fahrenheit to Celcius:");
            var input1 = Convert.ToDouble(Console.ReadLine());

            
            var fahrenheit = TempConverter.CelciusToFahrenheit(input);
            var celcius = TempConverter.FahrenheitToCelcius(input1);

            Console.WriteLine("After conversion:");
            Console.WriteLine($"{input} degrees Celcius is {fahrenheit} degrees in Fahrenheit.");
            Console.WriteLine($"{input1} degrees Fahrenheit is {celcius} degrees in Celcius.");
            
        }
    }
}
