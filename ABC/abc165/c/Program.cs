using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var q = int.Parse(_[2]);

            var l = new List<int[]>();
            for(var i = 0; i < q; i++){
                var __ = Console.ReadLine().Split().Select(k => int.Parse(k)).ToArray();
                l.Add(__);
            }

            var maxVal = long.MinValue;
            foreach(var s in Enumerate(Enumerable.Range(1,m).ToArray(), n, true)){
                //Console.WriteLine(string.Join(" ", s.Select(o => o.ToString())));
                var t = 0L;
                foreach(var ary in l){
                    //Console.WriteLine(string.Join(" ", ary.Select(o => o.ToString())));
                    t += s[ary[1]-1] - s[ary[0]-1] == ary[2] ? ary[3] : 0;
                }
                maxVal = Math.Max(maxVal,t);
            }

            Console.WriteLine(maxVal);
        }

        public static IEnumerable<T[]> Enumerate<T>(IEnumerable<T> items, int k, bool withRepetition) {
            if (k == 1) {
                foreach (var item in items)
                    yield return new T[] { item };
                yield break;
            }
            foreach (var item in items) {
                var leftside = new T[] { item };

                var unused = withRepetition ? items : items.SkipWhile(e => !e.Equals(item)).Skip(1).ToList();

                foreach (var rightside in Enumerate(unused, k - 1, withRepetition)) {
                    yield return leftside.Concat(rightside).ToArray();
                }
            }
        }
    }
}
