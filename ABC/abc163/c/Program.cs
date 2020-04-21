using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            var d = new Dictionary<long,long>();
            for(var i = 0; i < n - 1; i++){
                if(d.ContainsKey(a[i])){
                    d[a[i]] += 1;
                }else{
                    d.Add(a[i], 1);
                }
            }

            for(var i = 1; i <= n; i++){
                if(d.ContainsKey(i)){
                    Console.WriteLine(d[i]);
                }else{
                    Console.WriteLine(0);
                }
            }
        }
    }
}
