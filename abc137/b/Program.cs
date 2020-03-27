using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var k = int.Parse(_[0]);
            var x = int.Parse(_[1]);

            var minPos = (x - k + 1) >= -1000000 ? (x - k + 1) : -1000000;
            var l = Enumerable.Range(minPos, k * 2 - 1).Where(i => i <= 1000000).Select(i => i.ToString()).ToArray();

            Console.WriteLine(string.Join(" ", l));
        }
    }
}
