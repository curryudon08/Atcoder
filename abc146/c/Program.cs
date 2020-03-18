using System;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            var a =  BigInteger.Parse(line[0]);
            var b =  BigInteger.Parse(line[1]);
            var x =  BigInteger.Parse(line[2]);

            var left = new BigInteger(0);
            var right = new BigInteger(1000000001);
            while(right - left > 1){
                var mid = (left + right) / 2;
                var l = mid.ToString().Length;
                if(a * mid + b * l > x){
                    right = mid;
                }else{
                    left = mid;
                }

            }
            Console.WriteLine(left);
        }
    }
}
