using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var d = new Dictionary<long, bool>();
            for(var i = 0; i < n; i++){
                var a = long.Parse(Console.ReadLine());
                if(d.ContainsKey(a)){
                    d[a] = !d[a];
                }else{
                    d.Add(a, true);
                }
            }

            var count = d.Count(t => t.Value);
            Console.WriteLine(count);
        }
    }
}
