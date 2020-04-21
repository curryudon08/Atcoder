using System;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var h = BigInteger.Parse(s[0]);
            var w = BigInteger.Parse(s[1]);

            if(h == 1 || w == 1){
                Console.WriteLine(1);
            }else{
                var x = h * w;
                Console.WriteLine(x % 2 == 0 ? x / 2 : x / 2 + 1);
            }
        }
    }
}
