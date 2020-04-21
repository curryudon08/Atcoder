using System;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var a = BigInteger.Parse(s[0]);
            var b = BigInteger.Parse(s[1]);
            var c = BigInteger.Parse(s[2]);

            var x = c - a - b;
            if((x > 0) && (x * x > 4 * a * b)){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
