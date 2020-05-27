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
            var n = long.Parse(_[0]);
            var m = long.Parse(_[0]);
            var x = long.Parse(_[0]);

            var l = new List<long[]>();
            for(var i = 0; i < n; i++){
                var a = Console.ReadLine().Split().Select(t => long.Parse(t)).ToArray();
                l.Add(a);
            }

        }

        static long Solve(long n, long m, long x, long t, int[] s, int idx, List<long[]> l){
            var f = true;
            for(var i = 0; i < m; i++){
                if(s[i] < x){
                    f = false;
                    break;
                }
            }

            if(f){
                return t;
            }

            return Math.Min(n, m, x, t + )
        }
    }
}
