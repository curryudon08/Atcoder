using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var b = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();
            var c = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var total = 0;
            var pre = a[0] - 1;
            foreach(var i in a){
                var idx = i - 1;
                total += b[idx];
                if(pre + 1 == idx){
                    total += c[idx - 1];
                }
                pre = idx;
            }

            Console.WriteLine(total);
        }
    }
}
