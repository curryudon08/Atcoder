using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var t = int.Parse(_[1]);

            var ary = new Tuple<int,int>[n];
            for(var i = 0; i < n; i++){
                var __ = Console.ReadLine().Split();
                var ci = int.Parse(__[0]);
                var ti = int.Parse(__[1]);
                ary[i] = Tuple.Create(ci,ti);
            }
            var minv = ary.Where(x => x.Item2 <= t);

            if(minv.Any()){
                var m = minv.OrderBy(x => x.Item1).First();
                Console.WriteLine(m.Item1);
            }else{
                Console.WriteLine("TLE");
            }
        }
    }
}
