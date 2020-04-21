using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();
            var b = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            long count = 0;
            for(var i = 0; i < n; i++){
                if(a[i] >= b[i]){
                    count += b[i];
                }else{
                    count += a[i];
                    b[i] = Math.Max(b[i] - a[i], 0);
                    if(a[i + 1] >= b[i]){
                        count += b[i];
                        a[i + 1] = Math.Max(a[i + 1] - b[i], 0);
                    }else{
                        count += a[i + 1];
                        a[i + 1] = Math.Max(a[i + 1] - b[i], 0);
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
