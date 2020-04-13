using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var s = new int[n];
            for(var i = 0; i < n; i++){
                s[i] = int.Parse(Console.ReadLine());
            }

            var sum = s.Sum();
            if(sum % 10 != 0){
                Console.WriteLine(sum);
            }else{
                var t = s.Where(x => x % 10 != 0).OrderBy(x => x);
                if(t.Any()){
                    Console.WriteLine(sum - t.First());
                }else{
                    Console.WriteLine(0);
                }
            }
        }
    }
}
