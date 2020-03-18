using System;
using System.Linq;
using System.Collections.Generic;

namespace abc081_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var n = item[0];
            var k = item[1];

            var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var d = new Dictionary<int, int>();
            foreach(var i in a){
                if(d.ContainsKey(i)){
                    d[i] += 1;
                }else{
                    d.Add(i,1);
                }
            }
            var ans = 0;
            var l = d.Count - k;
            var j = 0;
            foreach(var t in d.OrderBy(x => x.Value)){
                if(j < l){
                    ans += t.Value;                
                }
                j += 1;
            }
            Console.WriteLine(ans);
        }
    }
}
