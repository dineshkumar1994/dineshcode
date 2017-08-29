using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Person_1:Address
    {
        private int age;
        private string name;

        public int getAge()
        {
            return age;
        }
        public void setAge(int age)
        {
            if (age <= 100)
            {
                this.age = age;
                Console.WriteLine(age);
            }
            else
                throw new Exception("Age should be between 0 and 100");


        }
        public string getName()
        {
            return name;
        }
        public void setNmae(string name)
        {

            if (name == "Dinesh" || name == "Mahesh")
            { this.name = name; }
            else
                throw new Exception("hello");

        }
    }
}
