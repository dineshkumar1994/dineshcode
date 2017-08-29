using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medication
{
    class Program
    {
        static void Main(string[] args)
        {
            Frequency f2 = new Frequency(Frequency.PartoftheDay.Evening);
            Console.WriteLine("{0}", f2.getPart());
            Frequency f1 = new Frequency();
            f1.setPart(Frequency.PartoftheDay.Morning);
            Console.WriteLine("{0}", f1.getPart());
            List<Frequency> fqls=new List<Frequency>();
            fqls.Add(f1);
            fqls.Add(f2);
            Medicine med2 = new Medicine("Ibuprofen", "38g", "For body pains");
            Medicine med1 = new Medicine("Paracetemol", "38g", "For fever");
            Console.WriteLine("The Tablet name is {0},and tablet composition is{1},and is for {2}", med1.getName(), med1.getComposition(), med1.getDetails());
            Patient patient1 = new Patient("Deepthi", "For body pains");
            Console.WriteLine("and The patient name is {0},  {1}", patient1.getName(), patient1.getDisease());
            Console.ReadLine();
            List<Medicine> mdcs = new List<Medicine>();
            mdcs.Add(med1);
            mdcs.Add(med2);
            List <Patient> pats= new List<Patient>();
            pats.Add(patient1);
            foreach (var x in mdcs)
            {
                Console.WriteLine(x.getName());
             
                    Console.ReadLine();

            }


        }
    }
}