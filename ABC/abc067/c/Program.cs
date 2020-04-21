using System;
using System.Linq;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(x => long.Parse(x)).ToArray();

            var total = a.Sum();
            var t = 0L;
            var minVal = long.MaxValue;
            for(var i = 0; i < n - 1; i++){
                t += a[i];
                minVal = Math.Min(minVal, Math.Abs(total - (t * 2)));
            }

            Console.WriteLine(minVal);
        }
    }
}
