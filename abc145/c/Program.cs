using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = new List<Tuple<int,int>>();

            for(int i = 0; i < n; i++){
                var _ = Console.ReadLine().Split();
                var x = int.Parse(_[0]);
                var y = int.Parse(_[1]);
                l.Add(Tuple.Create(x,y));
            }

            var total = 0.0;
            var count = 0;
            foreach(var i in Enumerate(Enumerable.Range(0, n).ToArray())){
                for(var j = 0; j < i.Length - 1; j++){
                    var p1 = l[i[j]];
                    var p2 = l[i[j+1]];
                    var len =  Math.Sqrt(Math.Pow(p1.Item1 - p2.Item1, 2) + Math.Pow(p1.Item2 - p2.Item2, 2));
                    total += len;
                }
                count++;
            }

            Console.WriteLine(string.Format("{0:f10}",total / count));
        }

        static IEnumerable<T[]> Enumerate<T>(IEnumerable<T> items){
            if (items.Count() == 1){
                yield return new T[]{items.First()};
                yield break;
            }

            foreach (var item in items){
                var leftside = new T[]{item};
                var unused = items.Except(leftside);
                foreach(var rightside in Enumerate(unused)){
                    yield return leftside.Concat(rightside).ToArray();
                }
            }
        }
    }
}
