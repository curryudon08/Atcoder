using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var l = new List<Tuple<string,int,int>>();
            for(var i = 1; i <= n; i++){
                var _ = Console.ReadLine().Split();
                var s = _[0];
                var p = int.Parse(_[1]);
                l.Add(Tuple.Create(s, p, i));
            }

            var o = l.OrderBy(t => t.Item1).ThenByDescending(t => t.Item2);
            foreach(var t in o){
                Console.WriteLine(t.Item3);
            }
        }
    }
}
