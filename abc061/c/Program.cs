using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var k = long.Parse(_[1]);

            var d = new Dictionary<long,long>();
            for(var i = 0; i < n; i++){
                var __ = Console.ReadLine().Split();
                var a = long.Parse(__[0]);
                var b = long.Parse(__[1]);

                if(d.ContainsKey(a)){
                    d[a] += b;
                }else{
                    d.Add(a,b);
                }
            }

            var count = 0L;
            foreach(var item in d.OrderBy(i => i.Key)){
                count += item.Value;
                if(count >= k){
                    Console.WriteLine(item.Key);
                    break;
                }
            }

        }
    }
}
