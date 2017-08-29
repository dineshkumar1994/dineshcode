using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographics
{
    class Program
    {

        static void Main(string[] args)
        {

            Person person1 = new Person();
    
            person1.setName("dinesh");
            person1.setAge(110);
            Console.WriteLine("The person is named {0} and says {1}", person1.getName(), person1.getAge());

            Person person11 = new Person("dinkala", 150);
            //Console.WriteLine("The person is named {0} and says {1}", person11._name, person11._age);
            Console.WriteLine("The person is named {0} and says {1}", person11.getName(), person11.getAge());
            Console.ReadLine();
            Address persondetails = new Address(12, "wichitact", "manassa", "virginia", 20109);
            Console.WriteLine("address is {0}", persondetails.getZipcode());
            Console.ReadLine();


        }
    }
}

