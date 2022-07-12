using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_PARCIAL_POO
{
    public class Kelvin
    {
        public float Magnitud;
        public static float Cero_Absoluto;

        public static implicit operator Kelvin(float f)
        {
            return new Kelvin(f);
        }
        public static explicit operator Celcius(Kelvin kelvin)
        {
            return new Celcius(kelvin.Magnitud - 273.15f);
        }
        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            return new Fahrenheit(kelvin.Magnitud * 9 / 5 - 459.67f);
        }
        static Kelvin()
        {
            Cero_Absoluto = 0f;
        }

        public Kelvin(float magnitud)
        {
            Magnitud = magnitud;
        }

        public static bool operator ==(Kelvin temp1, Kelvin temp2)
        {
            return temp1.Magnitud == temp2.Magnitud;
        }

        public static bool operator !=(Kelvin temp1, Kelvin temp2)
        {
            return temp1.Magnitud != temp2.Magnitud;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Kelvin))
            {
                return false;
            }

            return this.Magnitud == ((Kelvin)obj).Magnitud;
        }

        public static Kelvin operator +(Kelvin tempKelvin, Fahrenheit tempFahrenheit)
        {
            return new Kelvin(tempKelvin.Magnitud + ((tempFahrenheit.Magnitud + 459.67f) * 5 / 9));
        }
        public static Kelvin operator +(Kelvin tempKelvin, Celcius tempCelcius)
        {
            return new Kelvin(tempKelvin.Magnitud + (tempCelcius.Magnitud + 273.15f));
        }

        public override string ToString()
        {
            return Convert.ToString(Magnitud);
        }
    }
}
