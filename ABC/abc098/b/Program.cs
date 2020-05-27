using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Trim();

            var maxV = 0;
            for(var i = 1; i < n; i++){
                var x = s.Substring(0, i);
                var y = s.Substring(i, n - i);

                var d = new Dictionary<char,int>();
                foreach(var c in x){
                    if(!d.ContainsKey(c)){
                        d.Add(c, 1);
                    }
                }
                foreach(var c in y){
                    if(d.ContainsKey(c)){
                        d[c] += 1;
                    }
                }

                var count = d.Where(t => t.Value >= 2).Count();
                maxV = Math.Max(maxV, count);
            }

            Console.WriteLine(maxV);
        }
    }
}
