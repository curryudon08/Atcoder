using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var h = new HashSet<int>(a);

            Console.WriteLine(n == h.Count() ? "YES" : "NO");
        }
    }
}
