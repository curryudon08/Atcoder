using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());

            var l = new List<BigInteger>();
            l.Add(BigInteger.Parse(Console.ReadLine()));
            l.Add(BigInteger.Parse(Console.ReadLine()));
            l.Add(BigInteger.Parse(Console.ReadLine()));
            l.Add(BigInteger.Parse(Console.ReadLine()));
            l.Add(BigInteger.Parse(Console.ReadLine()));
            var min = l.Min();

            BigInteger t = n % min == 0 ? n / min : (n / min) + 1;
            t += 4;

            Console.WriteLine(t);
        }
    }
}
