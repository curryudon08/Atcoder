using System;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger power = 1;
            for(var i = 1; i <= n; i++){
                power = (power * i) % 1000000007;
            }
            Console.WriteLine(power);
        }
    }
}
