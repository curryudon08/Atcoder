using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var d = new Dictionary<int, int>();
            for(var i = 0; i < n; i++){
                d.Add(i + 1, a[i]);
            }

            var sorted = d.OrderBy(k => k.Value);
            Console.WriteLine(string.Join(" ",sorted.Select(v => v.Key.ToString())));
        }
    }
}
