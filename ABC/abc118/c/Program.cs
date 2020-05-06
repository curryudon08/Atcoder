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
            var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

            var x = a[0];
            for(var i = 1; i < n; i++){
                x = Gcd(a[i], x);
            }

            Console.WriteLine(x);
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
