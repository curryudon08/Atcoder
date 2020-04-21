using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var flag = true;
            for(var i = h.Length - 1; i > 0; i--){
                if(h[i] < h[i-1]){
                    if(h[i] >= h[i-1] - 1){
                        h[i-1] -= 1;
                    }else{
                        flag = false;
                        break;
                    }
                }                
            }

            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
