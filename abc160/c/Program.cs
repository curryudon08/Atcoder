using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var k = int.Parse(_[0]);
            var n = int.Parse(_[1]);

            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToList();
            a.Add(k + a[0]);

            var diff = Enumerable.Range(0,n).Select(i => a[i+1] - a[i]).ToList();
            var distance = diff.Sum() - diff.Max();
            Console.WriteLine(distance);
        }
    }
}
