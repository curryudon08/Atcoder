using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var minVal = int.MaxValue;
            for(var i = 1; i < n; i++){
                var front = w.Take(i).Sum();
                var back = w.Skip(i).Sum();
                var abs = Math.Abs(front - back);
                minVal = Math.Min(minVal, abs);
            }

            Console.WriteLine(minVal);
        }
    }
}
