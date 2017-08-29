using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Person
    {

        static void Main(string[] args)
        {
            Person_1 p1 = new Person_1();
            p1.setAge(100);
            p1.setNmae("Dinesh");
            Address a1 = new Address();
            a1.setAptno(32);
            a1.setStreet("wichitact");
            a1.setCity("manassas");
            a1.setState("virginia");


           

        }
    }
}
