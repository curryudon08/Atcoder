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
            var k = int.Parse(_[1]);

            var s = new bool[n];
            for(var i = 0; i < k; i++){
                var d = int.Parse(Console.ReadLine());
                var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
                for(var j = 0; j < d; j++){
                    s[a[j]-1] = true;
                }
            }

            Console.WriteLine(s.Count(f => !f));
        }
    }
}
