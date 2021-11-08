using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius (double a)
        {
            return (a - 32) * 5/9;
        }
        public static double CelciusToFahrenheit (double a)
        {
            return (a * 9 / 5) + 32;
        }
            
    }
}
