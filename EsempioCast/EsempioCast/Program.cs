using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioCast
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -65555;
            Console.WriteLine($"il valore di a è {a}")
            short s = (short)a;
            Console.WriteLine($"il valore di s è {s}");
            Console.ReadLine();
        }
    }
}
