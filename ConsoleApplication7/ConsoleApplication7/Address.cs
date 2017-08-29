using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Address
    {

            private string street;
            private int aptno;
            private string city;
            private string state;

            public string getStreet()
            {
                return street;

            }
            public void setStreet(string street)
            {
                this.street = street;
                Console.WriteLine(street);
            }

            public int getAptno()
            {
                return aptno;

            }
            public void setAptno(int aptno)
            {
                this.aptno = aptno;
                Console.WriteLine(aptno);
            }
            public string getCity()
            {
                return city;

            }
            public void setCity(string city)
            {
                this.city = city;
                Console.WriteLine(city);
            }
            public string getState()
            {
                return state;

            }
            public void setState(string state)
            {
                this.state = state;
                Console.WriteLine(state);
                Console.ReadLine();
            }
             
          

        }
    }

