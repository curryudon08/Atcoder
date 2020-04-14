using System;
using System.Numerics;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var m = long.Parse(_[1]);

            if(Math.Abs(n - m) <= 1){
                var s = 0L;
                if((n + m) % 2 != 0){
                    s = Calc(n, 1000000007) * Calc(m, 1000000007);
                }else{
                    s = (Calc(n, 1000000007) * Calc(m, 1000000007)) * 2;
                }                
                Console.WriteLine(s % 1000000007);
            }else{
                Console.WriteLine(0);
            }
        }

        static long Calc(long x, long mod){
            var val = 1L;
            while(x > 0){
                val =  val * x % mod;
                x--;
            }
            return val;
        }
    }
}
