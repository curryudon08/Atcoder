using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();
            var t = Console.ReadLine().ToCharArray();

            var count = Enumerable.Range(0, s.Length).Count(i => s[i] == t[i]);
            Console.WriteLine(count);
        }
    }
}
