using System;
using System.Collections.Generic;
using System.Linq;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToList();
            var d = new Dictionary<long, long>();
            foreach(var i in a){
                if(d.ContainsKey(i)){
                    d[i] += 1;
                }else{
                    d.Add(i, 1);
                }
            }

            var total = 0L;
            foreach(var i in d.Values){
                total += (i * (i - 1)) / 2;
            }

            for(var i = 0; i < n; i++){
                var val = d[a[i]];
                var count = total;
                count -= (val * (val - 1)) / 2;
                count += ((val - 1) * (val - 2)) / 2;
                Console.WriteLine(count);
            }

        }
    }
}
