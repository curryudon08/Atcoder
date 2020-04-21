using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = s[0];
            var k = s[1];
            var h = Console.ReadLine().Split().Select(i => long.Parse(i)).OrderByDescending(i => i).ToArray();

            var attack = h.Skip(k).Sum();
            Console.WriteLine(attack);
        }
    }
}
