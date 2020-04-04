using System;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var city = new int[n];
            for(var i = 0; i < m; i++){
                var r = Console.ReadLine().Split();
                city[int.Parse(r[0])-1] += 1;
                city[int.Parse(r[1])-1] += 1;
            }

            for(var i = 0; i < n; i++){
                Console.WriteLine(city[i]);
            }
        }
    }
}
