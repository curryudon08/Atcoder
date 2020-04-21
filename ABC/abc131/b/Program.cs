using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var l = int.Parse(_[1]);

            var a = new List<int>();
            for(var i = 1; i <= n; i++){
                a.Add(l + i - 1);
            }

            var sum = a.Sum();
            var val = sum - (sum - (a[0] < 0 ? a[0] * -1 : a[0]));
            var ans = 0;
            for(var i = 1; i < n; i++){
                var v = a[i] < 0 ? a[i] * -1 : a[i];
                if(val > sum - (sum - v)){
                    val = sum - (sum - v);
                    ans = i;
                }
            }

            Console.WriteLine(sum - a[ans]);
        }
    }
}
