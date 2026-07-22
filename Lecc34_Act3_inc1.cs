using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== CONVERTIDOR DE TEMPERATURA ===");
        Console.Write("Ingresa los grados Centígrados (°C): ");
        double celsiusIngresado = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsiusIngresado * 9 / 5) + 32;
        double celsius = celsiusIngresado; 
        double kelvin = celsiusIngresado + 273.15;
        Console.WriteLine($"\n Resultados:");
        Console.WriteLine($"a. Fahrenheit: {fahrenheit} °F");
        Console.WriteLine($"b. Celsius: {celsius} °C");
        Console.WriteLine($"c. Kelvin: {kelvin} K");
    }
}
