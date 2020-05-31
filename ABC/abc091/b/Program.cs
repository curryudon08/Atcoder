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
            var d = new Dictionary<string,int>();
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().Trim();
                if(d.ContainsKey(s)){
                    d[s] += 1;
                }else{
                    d.Add(s,1);
                }
            }

            var m = int.Parse(Console.ReadLine());
            for(var i = 0; i < m; i++){
                var s = Console.ReadLine().Trim();
                if(d.ContainsKey(s)){
                    d[s] -= 1;
                }else{
                    d.Add(s,-1);
                }
            }

            var minV = d.Max(x => x.Value);
            Console.WriteLine(minV >= 0 ? minV : 0);
        }
    }
}
