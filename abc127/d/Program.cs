using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var a = Console.ReadLine();

            var d = new Dictionary<long, long>();
            foreach(var i in a.Split()){
                var x = long.Parse(i);
                if(d.ContainsKey(x)){
                    d[x] += 1;
                }else{
                    d.Add(x, 1);
                }
            } 

            for(var i = 0; i < m; i++){
                var t = Console.ReadLine().Split();
                var b = long.Parse(t[0]);
                var c = long.Parse(t[1]);
                if(d.ContainsKey(c)){
                    d[c] += b;
                }else{
                    d.Add(c, b);
                }
            }

            BigInteger total = 0;
            var count = 0L;
            foreach(var i in d.OrderByDescending(i => i.Key)){
                var key = i.Key;
                var val = i.Value;
                if(count + val <= n){
                    total += (key * val);
                    count += val;
                }else{
                    total += (key * (n - count));
                    break;
                }

            }

            Console.WriteLine(total);
        }
    }
}
