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
            var p = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var q = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var i = 1;
            var a = 0;
            var b = 0;
            foreach(var l in Enumerate(Enumerable.Range(1, n).ToArray())){
                if(l.SequenceEqual(p)){
                    a = i;
                }
                if(l.SequenceEqual(q)){
                    b = i;
                }
                i += 1;
            }

            Console.WriteLine(Math.Abs(a - b));
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
