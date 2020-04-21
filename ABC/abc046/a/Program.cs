using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split();
            var s = new HashSet<string>(n);
            
            Console.WriteLine(s.Count());
        }
    }
}
