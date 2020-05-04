using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = BigInteger.Parse(Console.ReadLine());
            var n = BigInteger.Parse("100");

            var year = 0;
            while(n < x){
                n += n / 100;
                year += 1;
            }

            Console.WriteLine(year);
        }
    }
}
