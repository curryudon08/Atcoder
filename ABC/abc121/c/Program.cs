using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var m = long.Parse(_[1]);

            var d = new Dictionary<long,long>();
            for(var i = 0; i < n; i++){
                var __ = Console.ReadLine().Split();
                var a = long.Parse(__[0]);
                var b = long.Parse(__[1]);
                if(d.ContainsKey(a)){
                    d[a] += b;
                }else{
                    d.Add(a, b);
                }
            }

            BigInteger p = 0;
            foreach(var item in d.OrderBy(x => x.Key)){
                if(m <= 0){
                    break;
                }

                if(m - item.Value >= 0){
                    p += (item.Key * item.Value);
                    m -= item.Value;
                }else{
                    p += (item.Key * m);
                    m = 0;
                }
            }

            Console.WriteLine(p);
        }
    }
}
