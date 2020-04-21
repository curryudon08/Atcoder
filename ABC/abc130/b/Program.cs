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
            var x = int.Parse(_[1]);
            var l = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var d = 0;
            var count = 1;
            for(var i = 1; i < n + 1; i++){
                d += l[i - 1];
                if(d <= x){
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
