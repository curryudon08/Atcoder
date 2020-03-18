using System;
using System.Linq;
using System.Collections.Generic;

namespace dp_a
{
    class Program
    {
        static void Main(string[] args)
        {
            var dp = new long[100010].Select(x => 9223372036854775807).ToArray();
            dp[0] = 0;

            var n = int.Parse(Console.ReadLine());
            var h = Console.ReadLine().Split().Select(x => long.Parse(x)).ToArray();

            for(int i = 1; i < n; i++){
                dp[i] = Math.Min(dp[i], dp[i-1] + Math.Abs(h[i] - h[i-1]));
                if(i > 1){
                    dp[i] = Math.Min(dp[i], dp[i-2] + Math.Abs(h[i] - h[i-2]));
                }
            }
            Console.WriteLine(dp[n-1]);
        }
    }
}
