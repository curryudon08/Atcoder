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
            var p = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var l = 0;
            for(var i = 0; i < n; i++){
                if(p[i] != i + 1){
                    l++;
                }
            }

            if(l > 2){
                Console.WriteLine("NO");
            }else{
                Console.WriteLine("YES");
            }
        }
    }
}
