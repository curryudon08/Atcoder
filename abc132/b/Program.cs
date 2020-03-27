using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = Console.ReadLine().Split().Select(i => int.Parse(i)).ToList();

            var count = 0;
            for(var i = 1; i < n - 1; i++){
                var l = p.GetRange(i-1,3);
                var min = l.Min();
                var max = l.Max();

                if(p[i] != min && p[i] != max){
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
