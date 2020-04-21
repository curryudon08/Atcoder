using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            var d = new Dictionary<long,long>();
            for(var i = 0; i < n; i++){
                var x = a[i];
                if(d.ContainsKey(x)){
                    d[x] += 1;
                }else{
                    d.Add(x, 1);
                }

                if(d.ContainsKey(x+1)){
                    d[x+1] += 1;
                }else{
                    d.Add(x+1, 1);
                }

                if(d.ContainsKey(x-1)){
                    d[x-1] += 1;
                }else{
                    d.Add(x-1, 1);
                }
            }

            var max = d.Max(t => t.Value);
            Console.WriteLine(max);
        }
    }
}
