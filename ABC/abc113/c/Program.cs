using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var t = new Tuple<int,int,int>[m];
            for(var i = 0; i < m; i++){
                var __ = Console.ReadLine().Split();
                var p = int.Parse(__[0]);
                var y = int.Parse(__[1]);
                t[i] = Tuple.Create(i, p, y);
            }

            var id = new string[m];
            var count = new int[n];
            foreach(var x in t.OrderBy(i => i.Item2).ThenBy(i => i.Item3)){
                id[x.Item1] = string.Format("{0:D6}{1:D6}",x.Item2,count[x.Item2-1]+1);
                count[x.Item2-1]++;
            }

            foreach(var x in id){
                Console.WriteLine(x);
            }
        }
    }
}
