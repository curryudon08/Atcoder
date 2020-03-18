using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var h = int.Parse(s[0]);
            var n = int.Parse(s[1]);
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();

            Console.WriteLine(h - a <= 0 ? "Yes" : "No");
        }
    }
}
