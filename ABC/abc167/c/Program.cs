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
            var n = long.Parse(_[0]);
            var m = long.Parse(_[1]);
            var x = long.Parse(_[2]);

            var c = new long[n];
            var l = new long[n,m];
            for(var i = 0; i < n; i++){
                var a = Console.ReadLine().Split().Select(t => long.Parse(t)).ToArray();
                c[i] = a[0];
                for(var j = 1; j <= m; j++){
                    l[i,j-1] = a[j];
                }
            }

            var ans = long.MaxValue;
            for(var b = 0; b < Math.Pow(2,n); b++){
                var skill = new long[m];
                var cost = 0L;
                for(var i = 0; i < n; i++){
                    if(((b >> i) & 1) == 1){
                        cost += c[i];
                        for(var j = 0; j < m; j++){
                            skill[j] += l[i,j];
                        }
                    }
                }

                var f = true;
                for(var k = 0; k < m; k++){
                    if(skill[k] < x){
                        f = false;
                        break;
                    }
                }

                if(f){
                    ans = Math.Min(ans,cost);
                }
            }

            Console.WriteLine(ans == long.MaxValue ? -1 : ans);
        }
    }
}
