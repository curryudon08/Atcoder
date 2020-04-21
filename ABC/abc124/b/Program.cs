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
            var h = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var maxVal = h[0];
            var count = 0;
            for(var i = 0; i < n; i++){
                if(maxVal <= h[i]){
                    count++;
                }
                maxVal = Math.Max(maxVal, h[i]);
            }

            Console.WriteLine(count);
        }
    }
}
