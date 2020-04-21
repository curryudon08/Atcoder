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

            var l = new List<Tuple<int, char>>();
            for(var i = 0; i < n; i++){
                var _ = Console.ReadLine().Split();
                var x = int.Parse(_[0]);
                var c = Convert.ToChar(_[1]);

                l.Add(Tuple.Create(x,c));
            }

            var r = l.Where(t => t.Item2 == 'R').OrderBy(t => t.Item1).ToArray();
            foreach(var i in r){
                Console.WriteLine(i.Item1);
            }

            var b = l.Where(t => t.Item2 == 'B').OrderBy(t => t.Item1).ToArray();
            foreach(var i in b){
                Console.WriteLine(i.Item1);
            }
        }
    }
}
