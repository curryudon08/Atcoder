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

            var l1 = new List<int>();
            var l2 = new List<int>();
            for(var i = 0; i < m; i++){
                var s = Console.ReadLine().Split();
                var a = int.Parse(s[0]);
                var b = int.Parse(s[1]);

                if(a == 1){
                    l1.Add(b);
                }else if(b == n){
                    l2.Add(a);
                }
            }

            var l = l1.Intersect(l2);
            Console.WriteLine(l.Any() ? "POSSIBLE" : "IMPOSSIBLE");
        }
    }
}
