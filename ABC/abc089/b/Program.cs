using System;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = new HashSet<string>(Console.ReadLine().Split());

            Console.WriteLine(s.Count == 3 ? "Three" : "Four");
        }
    }
}
