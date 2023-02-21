namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(150);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(70);

            Console.WriteLine($"celsius: {celsius}");
            Console.WriteLine($"fahrenheit: {fahrenheit}");

        }
    }
}
