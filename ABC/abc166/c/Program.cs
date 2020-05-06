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
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var h = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var r = new bool[n];
            for(var i = 0; i < n; i++){
                r[i] = true;
            }

            for(var i = 0; i < m; i++){
                var __ = Console.ReadLine().Split();
                var a = int.Parse(__[0]);
                var b = int.Parse(__[1]);

                if(h[a-1] <= h[b-1]){
                    r[a-1] = false;
                }

                if(h[b-1] <= h[a-1]){
                    r[b-1] = false;
                }
            }

            Console.WriteLine(r.Count(f => f));
        }
    }
}
