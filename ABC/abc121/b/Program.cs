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
            var c = int.Parse(_[2]);
            var b = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            var count = 0;
            for(var i = 0; i < n; i++){
                var a = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                var t = Enumerable.Range(0, m).Select(j => a[j] * b[j]).Sum() + c;
                count += t > 0 ? 1 : 0;
            }

            Console.WriteLine(count);
        }
    }
}
