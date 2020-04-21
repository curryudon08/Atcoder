using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            while(a.Length > 1){
                var min = a.Min();
                a = a.Select(i => i % min).Where(i => i != 0).ToArray();
            }

            Console.WriteLine(a[0]);
        }
    }
}
