using System;
using System.Numerics;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = BigInteger.Parse(_[0]);
            var b = BigInteger.Parse(_[1]);
            var n = BigInteger.Parse(_[2]);

            var x = b > n ? n : b - 1;
            var ans = (a * x / b) - (a * (x / b));
            Console.WriteLine(ans);
        }
    }
}
