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
            var q = long.Parse(_[1]);
            var s = Console.ReadLine().ToCharArray();

            var w = new long[s.Length];
            w[0] = 0;
            for(var i = 0; i < s.Length - 1; i++){
                w[i + 1] = w[i];
                if(s[i] == 'A' && s[i+1] == 'C'){
                    w[i + 1] += 1;
                }
            }

            for(var i = 0; i < q; i++){
                var t = Console.ReadLine().Split();
                var l = long.Parse(t[0]);
                var r = long.Parse(t[1]);

                Console.WriteLine(w[r-1] - w[l-1]);
            }
        }
    }
}
