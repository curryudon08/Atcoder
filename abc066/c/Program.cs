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
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var front = new List<int>();
            var back = new List<int>();
            for(var i = 1; i <= n; i++){
                if(i % 2 != 0){
                    front.Add(a[i - 1]);
                }else{
                    back.Add(a[i - 1]);
                }
            }

            if(n % 2 != 0){
                front.Reverse();
                var s = front.Concat(back);
                Console.WriteLine(string.Join(" ", s.Select(i => i.ToString())));
            }else{
                back.Reverse();
                var s = back.Concat(front);
                Console.WriteLine(string.Join(" ", s.Select(i => i.ToString())));
            }
        }
    }
}
