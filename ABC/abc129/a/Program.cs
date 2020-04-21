using System;
using System.Collections.Generic;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var p = int.Parse(_[0]);
            var q = int.Parse(_[1]);
            var r = int.Parse(_[2]);

            var l = new int[3];
            l[0] = p + q;
            l[1] = p + r;
            l[2] = q + r;

            Console.WriteLine(l.Min());
        }
    }
}
