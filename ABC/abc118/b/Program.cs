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
            var m = int.Parse(_[1]);

            var f = new int[m];
            for(var i = 0; i < n; i++){
                var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for(var j = 0; j < a[0]; j++){
                    var idx = a[j+1];
                    f[idx-1] += 1;
                }
            }

            Console.WriteLine(f.Count(x => x == n));
        }
    }
}
