using System;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = BigInteger.Parse(_[0]);
            var b = BigInteger.Parse(_[1]);
            var c = BigInteger.Parse(_[2]);

            var x = (a * b * c) % 1000000007;
            Console.WriteLine(x);
        }
    }
}
