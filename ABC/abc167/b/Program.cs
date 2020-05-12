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
            var a = long.Parse(_[0]);
            var b = long.Parse(_[1]);
            var c = long.Parse(_[2]);
            var k = long.Parse(_[3]);

            var total = 0L;
            if(a > 0){
                if(k >= a){
                    total += a;
                    k -= a;
                }else{
                    total += k;
                    k = 0;
                }
            }

            if(k > 0 && b > 0){
                k -= b;
            }

            if(k > 0 && c > 0){
                if(k >= c){
                    total -= c;
                }else{
                    total -= k;
                }
            }

            Console.WriteLine(total);
        }
    }
}
