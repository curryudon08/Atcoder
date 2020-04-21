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

            var minPos = 0;
            var maxPos = int.MaxValue;
            for(var i = 0; i < m; i++){
                var t = Console.ReadLine().Split();
                var l = int.Parse(t[0]);
                var r = int.Parse(t[1]);

                minPos = Math.Max(minPos, l);
                maxPos = Math.Min(maxPos, r);
            }

            var count = maxPos - minPos + 1;
            Console.WriteLine(count > 0 ? count : 0);
        }
    }
}
