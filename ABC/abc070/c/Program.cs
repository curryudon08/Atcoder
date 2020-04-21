using System;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var ans = BigInteger.Parse(Console.ReadLine());
            for(var i = 1; i < n; i++){
                var t = BigInteger.Parse(Console.ReadLine());
                ans = Lcm(t, ans);
            }

            Console.WriteLine(ans);
        }

        static BigInteger Lcm(BigInteger m, BigInteger n){
        	return (m * n) / Gcd(m, n);
        }

        static BigInteger Gcd(BigInteger m, BigInteger n)
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
