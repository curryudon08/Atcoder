using System;
using System.Numerics;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            var a = BigInteger.Parse(line[0]);
            var b = BigInteger.Parse(line[1]);
            var k = BigInteger.Parse(line[2]);

            if(k >= a){
                k -= a;
                a = 0;
                b = (b >= k ? b - k : 0);
            }else{
                a -= k;                
            }

            Console.WriteLine(string.Format("{0} {1}", a, b));
        }
    }
}
