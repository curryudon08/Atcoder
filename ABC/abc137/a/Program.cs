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
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            var l = new List<int>();
            l.Add(a + b);
            l.Add(a - b);
            l.Add(a * b);

            Console.WriteLine(l.Max());
        }
    }
}
