using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(Lcm(2,n));
        }

        //最小公倍数
        static long Lcm(long m, long n){
        	return (m * n) / Gcd(m, n);
        }

        //最大公約数
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
