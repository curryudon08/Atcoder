using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var t = new string('x', s.Length);

            Console.WriteLine(t);
        }
    }
}
