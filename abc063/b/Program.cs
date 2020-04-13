using System;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();
            var h = new HashSet<char>(s);

            Console.WriteLine(s.Length == h.Count ? "yes" : "no");
        }
    }
}
