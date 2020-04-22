using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var n = long.Parse(_[0]);
            var y = long.Parse(_[1]);

            var flag = Solve(n, y);
            if(!flag){
                Console.WriteLine("-1 -1 -1");
            }
        }

        static bool Solve(long n, long y){
            for(var i = 0; i <= n; i++){
                for(var j = 0; j <= n - i; j++){
                    var k = n - i - j;

                    var total = (10000 * i) + (5000 * j) + (1000 * k);
                    if(total == y){
                        Console.WriteLine(string.Format("{0} {1} {2}", i, j, k));
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
