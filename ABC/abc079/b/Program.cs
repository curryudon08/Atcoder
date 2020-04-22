using System;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var a = new BigInteger[n + 1];
            a[0] = 2;
            a[1] = 1;

            for(var i = 2; i <= n ;i++){
                a[i] = a[i - 1] + a[i - 2];
            }

            Console.WriteLine(a[n]);
        }
    }
}
