using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray().ToList();
            var first = s.IndexOf('A');
            var last = s.LastIndexOf('Z');
            Console.WriteLine(last - first + 1);
        }
    }
}
