using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_PARCIAL_POO
{
    public class Fahrenheit
    {
        public float Magnitud;
        public static float Cero_Absoluto;

        public static implicit operator Fahrenheit(float f)
        {
            return new Fahrenheit(f);
        }

        public static explicit operator Celcius(Fahrenheit fahrenheit)
        {
            return new Celcius((fahrenheit.Magnitud - 32) * 5 / 9);
        }
        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return new Kelvin((fahrenheit.Magnitud + Cero_Absoluto) * 5 / 9);
        }
        static Fahrenheit()
        {
            Cero_Absoluto = -459.67f;
        }

        public Fahrenheit(float magnitud)
        {
            Magnitud = magnitud;
        }

        public static bool operator ==(Fahrenheit temp1, Fahrenheit temp2)
        {
            return temp1.Magnitud == temp2.Magnitud;
        }

        public static bool operator !=(Fahrenheit temp1, Fahrenheit temp2)
        {
            return temp1.Magnitud != temp2.Magnitud;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Fahrenheit))
            {
                return false;
            }

            return this.Magnitud == ((Fahrenheit)obj).Magnitud;
        }

        public static Fahrenheit operator +(Fahrenheit tempFahrenheit, Kelvin tempKelvin)
        {
            return new Fahrenheit(tempFahrenheit.Magnitud + ((tempKelvin.Magnitud -273.15f) * 9/5 +32));
        }
        public static Fahrenheit operator +(Fahrenheit tempFahrenheit, Celcius tempCelcius)
        {
            return new Fahrenheit(tempFahrenheit.Magnitud + ((tempCelcius.Magnitud * 9 / 5)+32));
        }

        public override string ToString()
        {
            return Convert.ToString(Magnitud);
        }
    }
}