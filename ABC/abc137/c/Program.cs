using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var h = new Dictionary<string, long>();

            long count = 0;
            for(var i = 0; i < n; i++){
                var s = string.Join("", Console.ReadLine().ToCharArray().OrderBy(t => t));
                if(!h.ContainsKey(s)){
                    h.Add(s, 1);
                }else{
                    h[s] += 1;
                }
                count += (h[s] - 1);
            }

            Console.WriteLine(count);
        }
    }
}
