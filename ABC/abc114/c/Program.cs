using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var res = Solve(n, "");

            Console.WriteLine(res);
        }

        static long Solve(long n, string s){
            if(s.Length != 0  && long.Parse(s) > n){
                return 0 ;
            }

            long res = "753".Count(x => s.Contains(x)) == 3 ? 1 : 0;
            res += Solve(n, s + "3");
            res += Solve(n, s + "5");
            res += Solve(n, s + "7");
            return res;
        }
    }
}
