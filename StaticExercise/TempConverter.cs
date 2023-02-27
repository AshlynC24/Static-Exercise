using System;
namespace StaticExercise
{
	public static class TempConverter
	{
		public static double FahrenheitToCelsius (double fahrenheit)
		{
			return (fahrenheit - 32) / 1.8;
		}
		public static double CelsiusToFahrenheit(double celcius)
		{
			return (celcius * 9) / 5 + 32;
		}
	}
}

