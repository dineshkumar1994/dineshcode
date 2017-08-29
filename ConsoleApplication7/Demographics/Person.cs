
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographics
{
    class Person
    {
        private string _name;
        private int _age;


        public Person(string name, int age)
        {
            this._name = name;
            if (age <= 100)
            {
                this._age = age;
                Console.WriteLine(age);
            }
            else


                Console.WriteLine("not a valid age");

        }
        public Person()
        {

        }
        public int getAge()
        {
            return _age;
        }
        public void setAge(int age)
        {
            if (age <= 100)
            {
                this._age = age;
                Console.WriteLine(age);
            }
            else Console.WriteLine("not a valid age");

        }
        public string getName()
        {
            return _name;
        }
        public void setName(string name)
        {

            this._name = name;

        }

    }
}
