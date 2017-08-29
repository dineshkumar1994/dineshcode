using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{

    public class Temperature
    {
        private double _celsius;
        public Location _location;
        public Location getLocation()
        {
            return _location;
        }
        public void setLocation(Location location)
        {
            this._location= location;
            
        }
        public Temperature(Location location)
        {
            this._location = location;

        }

        public void setCelsius(double celsius)
        {
            this._celsius = celsius;
            double fahrenheit1 = (celsius * 1.8) + 32;

            Console.WriteLine("{0}  f", fahrenheit1);

            double kelvin1 = (celsius + 273.15);
            Console.WriteLine("{0}  k", kelvin1);


            if (fahrenheit1 > 100.4)
            {
                Console.WriteLine("The patient has fever and temperature is {0} and location is {1}", fahrenheit1, Location.mouth);
            }
            else
                Console.WriteLine("The patient body temperature is {0} and location is {1}", fahrenheit1, Location.ampit);
        }
        public double getCelsius()
        {

            return this._celsius;
        }

        public enum Location
        {
            mouth,
            ear,
            ampit,

        }

    }
}

