using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var k = long.Parse(_[0]);
            var s = long.Parse(_[1]);

            var count = 0;
            for(var i = 0; i <= k; i++){
                for(var j = 0; j <= k; j++){
                    var n = s - i - j;
                    if(n >= 0 && n <= k){
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
