using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographics
{
    class Address
    {

        private int _aptno;
        private string _streetname;
        private string _city;
        private string _state;
        private int _zipcode;


         public Address(int aptno,string streetname,string city,string state,int zipcode)
        {
            this._aptno = aptno;
            this._streetname=streetname;
            this._city = city;
            this._state = state;
            
            this._zipcode = zipcode;


        }

        public string getStreetname()
        {
            return _streetname;

        }
        public void setStreetname(string streetname)
        {
            if (!streetname.Any(char.IsDigit))
            {
                this._streetname = streetname;
            }
            else
                this._streetname = "not a valid street";
            Console.WriteLine("street shouls contains only alphabelts");
            
        }

        public int getAptno()
        {
            return _aptno;

        }
        public void setAptno(int aptno)
        {  
            this._aptno = aptno;
            
        }
        public string getCity()
        {
            return _city;

        }
        public void setCity(string city)
        {
            this._city = city;
        }

        public string getState()
        {
            return _state;

        }
        public void setState(string state)
        {
            this._state = state;
        }
        public int getZipcode()
        {
            return _zipcode;

        }
        public void setZipcode(int zipcode)
        {
            this._zipcode = zipcode;
        }
       

       

          

        }
        
              
    }

