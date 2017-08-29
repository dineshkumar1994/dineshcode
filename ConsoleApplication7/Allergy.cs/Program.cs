using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allergy.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Severity s1 = new Severity("rakul", "rashes", DateTime.Now,Severity.Maximum.high);
            Console.WriteLine("{0},\n{1}\n,{2}\n{3}\n", s1.getNursename(), s1.getSymptoms(), s1.getTimeReported(),s1.getSeverity());
            Console.ReadLine();
            //Severity s2 = new Severity();

        }
    }
}
