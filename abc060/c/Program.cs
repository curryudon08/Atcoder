using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var t = long.Parse(_[1]);
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            var count = 0L;
            for(var i = 0; i < n-1; i++){
                if(s[i+1] - s[i] >= t){
                    count += t;
                }else{
                    count += (s[i+1] - s[i]);
                }
            }
            count += t;

            Console.WriteLine(count);
        }
    }
}
