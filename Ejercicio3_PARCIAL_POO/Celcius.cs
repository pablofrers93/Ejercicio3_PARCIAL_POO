using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_PARCIAL_POO
{
    public class Celcius
    {
        public float Magnitud;
        public static float Cero_Absoluto;

        public static implicit operator Celcius(float f)
        {
            return new Celcius(f);
        }

        public static explicit operator Fahrenheit(Celcius celcius)
        {
            return new Fahrenheit(celcius.Magnitud + 32);
        }

        static Celcius()
        {
            Cero_Absoluto = -273.15f;
        }

        public Celcius(float magnitud)
        {
            Magnitud = magnitud;
        }
        public static bool operator ==(Celcius temp1, Celcius temp2)
        {
            return temp1.Magnitud == temp2.Magnitud;
        }

        public static bool operator !=(Celcius temp1, Celcius temp2)
        {
            return temp1.Magnitud != temp2.Magnitud;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Celcius))
            {
                return false;
            }

            return this.Magnitud == ((Celcius)obj).Magnitud;                 
        }

        public static Celcius operator +(Celcius tempCelcius, Fahrenheit tempFahrenheit)
        {
            return new Celcius(tempCelcius.Magnitud+32);
        }
        public static Celcius operator +(Celcius tempCelcius, Kelvin tempKelvin)
        {
            return new Celcius(tempCelcius.Magnitud+(tempKelvin.Magnitud-Cero_Absoluto));
        }

        public override string ToString()
        {
            return Convert.ToString(Magnitud);
        }
    }
}
