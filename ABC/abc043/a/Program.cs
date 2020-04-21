using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Enumerable.Range(1, n).Sum();

            Console.WriteLine(s);
        }
    }
}
