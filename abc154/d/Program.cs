using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);
            var p = Console.ReadLine().Split().Select(i => double.Parse(i)).ToArray();

            var p2 = new double[p.Length+1];
            p2[0] = 0;

            for(var i = 1; i < p2.Length; i++){
                p2[i] = ((1.0 + p[i-1]) / 2.0) + p2[i-1];
            }

            var maxVal = 0.0;
            for(var i = k; i < p2.Length; i++){
                maxVal = Math.Max(p2[i] - p2[i-k], maxVal);
            }

            Console.WriteLine(string.Format("{0:f11}",maxVal));
        }
    }
}
