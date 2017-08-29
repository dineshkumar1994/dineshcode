using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
        Temperature fortaleza = new Temperature();
        //fortaleza.celciustofahrenheitkelvin(26);
		fortaleza.setCelsius(37);
		Console.WriteLine("The person cureent body temperature is {0} °C ",fortaleza.getCelsius());
        Console.ReadLine();
		
	}
}
    }

