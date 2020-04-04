using System;
using System.Collections.Generic;
using System.Linq;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var l = new List<Tuple<long,long>>();
            for(var i = 0; i < n; i++){
                var _ = Console.ReadLine().Split();
                var a = long.Parse(_[0]);
                var b = long.Parse(_[1]);

                l.Add(Tuple.Create(a, b));
            }

            var flag = true;
            var count = 0L;
            foreach(var item in l.OrderBy(i => i.Item2)){
                count += item.Item1;
                if(count > item.Item2){
                    flag = false;
                    break;
                }
            }

            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
