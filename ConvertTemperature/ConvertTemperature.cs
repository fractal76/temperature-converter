using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public static class ConvertTemperature
    {
        public static float CelsiusToFarenheit(float degreesC)
        {
            return degreesC * 1.8f + 32f;
        }

        public static float FarenheitToCelsius(float degreesF)
        {
            return (degreesF - 32f) / 1.8f;
        }

        public static float CelsiusToKelvin(float degreesC)
        {
            return degreesC + 273.15f;
        }

        public static float KelvinToCelsius(float degreesK)
        {
            return degreesK - 273.15f;
        }

        public static float FarenheitToKelvin(float degreesF)
        {
            return (degreesF - 32f) * 5f / 9f + 273.15f;
        }

        public static float KelvinToFarenheit(float degreesK)
        {
            return (degreesK - 273.15f) * 1.8f + 32f;
        }
    }
}
