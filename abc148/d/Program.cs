using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToList();

            var idx = 0;
            var count = 0;
            var num = 1;
            while(idx < n && count < n){
                if(a[idx] == num){
                    num++;                    
                }else{
                    count++;
                }
                idx++;
            }

            Console.WriteLine(count == n ? -1 : count);
        }
    }
}
