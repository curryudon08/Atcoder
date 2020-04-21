using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = BigInteger.Parse(_[0]);
            var k = BigInteger.Parse(_[1]);

            if(n % k == 0){
                Console.WriteLine(0);
            }else if(n >= k){
                var t = n % k;
                if(k - t > t){
                    Console.WriteLine(t);
                }else{
                    Console.WriteLine(k - t);
                }
            }else{
                if(k - n > n){
                    Console.WriteLine(n);
                }else{
                    Console.WriteLine(k - n);
                }
            }
        }
    }
}
