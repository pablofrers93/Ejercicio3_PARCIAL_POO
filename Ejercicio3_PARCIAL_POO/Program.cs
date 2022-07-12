using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_PARCIAL_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celcius TempCelcius = new Celcius(25);
            Fahrenheit TempFahrenheit = new Fahrenheit(80);
            Kelvin TempKelvin = new Kelvin(15);

            Console.WriteLine($"Suma de temp Celcius y Fahrenheit: {TempCelcius + TempFahrenheit}");

            Console.WriteLine($"Suma de temp Fahrenheit y Celcius: {TempFahrenheit + TempCelcius}");

            Console.WriteLine($"Suma de temp Kelvin y Celcius: {TempKelvin + TempCelcius}");

            Console.WriteLine($"Suma de temp Kelvin y Fahrenheit: {TempKelvin + TempFahrenheit}");

            TempFahrenheit = (Fahrenheit)TempKelvin;

            TempKelvin = (Kelvin)TempFahrenheit;

            Console.ReadLine();
        }
    }
}
