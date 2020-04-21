using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var k = int.Parse(_[1]);
            var h = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var count = h.Count(i => i >= k);
            Console.WriteLine(count);
        }
    }
}
