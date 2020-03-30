using System;
using System.Linq;
using System.Numerics;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            var sum = (1 + n) * n / 2;
            Console.WriteLine(sum - n);
        }
    }
}
