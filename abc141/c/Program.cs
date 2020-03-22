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
            var k = long.Parse(_[1]);
            var q = long.Parse(_[2]);

            var d = new Dictionary<int,long>();
            for(var i = 0; i < q; i++){
                var a = int.Parse(Console.ReadLine());
                if(d.ContainsKey(a)){
                    d[a] += 1;
                }else{
                    d.Add(a, 1);
                }
            }

            for(var i = 1; i < n + 1; i++){
                var p = q;
                if(d.ContainsKey(i)){
                    p -= d[i];
                }
                Console.WriteLine(k - p > 0 ? "Yes" : "No");
            }
        }
    }
}
