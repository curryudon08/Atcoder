using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var n = x[0];
            var l = x[1];

            var s = new List<string>();
            for(var i = 0; i < n; i++){
                var c = Console.ReadLine().Trim();
                s.Add(c);
            }

            var o = s.OrderBy(z => z).ToList();
            Console.WriteLine(string.Join("",o));
        }
    }
}
