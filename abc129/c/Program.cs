using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);

            var a = new bool[n + 1];
            for(var i = 0; i < m; i++){
                var t = int.Parse(Console.ReadLine());
                a[t] = true;
            }

            long[] dp = new long[n + 1];
            dp[0] = 1;
            dp[1] = a[1] ? 0 : 1;

            for(var i = 2; i <= n; i++){
                if(!a[i - 1]){
                    dp[i] += dp[i - 1]; 
                }
                if(!a[i - 2]){
                    dp[i] += dp[i - 2];
                }
                dp[i] %= 1000000007;

            }
            Console.WriteLine(dp[n]);
        }
    }
}
