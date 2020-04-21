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
            var n = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var count = 0;
            var vote = a.Sum();
            var limit = vote % (4 * m) == 0 ? vote / (4 * m) : vote / (4 * m) + 1;
            for(var i = 0; i < n; i++){
                if(a[i] >= limit){
                    count++;
                }
            }

            Console.WriteLine(count >= m ? "Yes" : "No");
        }
    }
}
