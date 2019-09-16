using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_test
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kvadrat(20));
        }

        static double kvadrat(double number)
        {
            // return number * number;
            return Math.Pow(number, 2);
        }
    }
}
