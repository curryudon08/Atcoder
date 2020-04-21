using System;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = BigInteger.Parse(_[0]);
            var b = BigInteger.Parse(_[1]);
            var c = BigInteger.Parse(_[2]);
            var d = BigInteger.Parse(_[3]);

            var cc = (b / c) - ((a - 1) / c);
            var dd = (b / d) - ((a - 1) / d);

            var e = Lcm(c, d);
            var ee = (b / e) - ((a - 1) / e);

            Console.WriteLine(b - a - cc - dd + ee + 1);
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
