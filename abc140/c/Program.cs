using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var b = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            var total = b[0];
            for(var i = 1; i < n - 1; i++){
                total += Math.Min(b[i], b[i-1]);
            }
            total += b[n-2];

            Console.WriteLine(total);
        }
    }
}
