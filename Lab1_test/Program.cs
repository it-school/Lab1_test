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
            int k = 3;
            for (int n = 1; n <= 5; n++)
                Console.WriteLine((n * k) % 24 + 1);
        }


        static double kvadrat(double number)
        {
            // return number * number;
            return Math.Pow(number, 2);
        }
    }
}
