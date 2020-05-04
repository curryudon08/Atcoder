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

            var d = new Dictionary<string, long>();
            for(var i = 0; i < n; i++){
                var s = Console.ReadLine().Trim();
                if(d.ContainsKey(s)){
                    d[s] += 1;
                }else{
                    d.Add(s, 1);
                }
            }

            Console.WriteLine(d.Count());
        }
    }
}
