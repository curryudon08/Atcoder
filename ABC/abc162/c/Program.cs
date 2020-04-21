using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var total = 0L;
            for(var i = 1L; i <= n; i++){
                for(var j = 1L; j <= n; j++){
                    for(var k = 1L; k <= n; k++){
                        var x = Gcd(i, j);
                        total += Gcd(x, k);
                    }
                }
            }

            Console.WriteLine(total);
        }

        static long Gcd(long m, long n)
        {
	        while (m % n != 0){
        		var temp = n;
		        n = m % n;
		        m = temp;
	        }
        	return n;
        }
    }
}
