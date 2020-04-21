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
            var n = int.Parse(Console.ReadLine());
            var t = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();            
            var m = int.Parse(Console.ReadLine());

            BigInteger sum = t.Sum();
            for(var i = 0; i < m; i++){
                var _ = Console.ReadLine().Split();
                var p = int.Parse(_[0]);
                var x = int.Parse(_[1]);

                Console.WriteLine(sum - t[p-1] + x);
            }
        }
    }
}
