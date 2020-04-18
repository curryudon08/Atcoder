using System;
using System.Linq;
using System.Collections.Generic;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var d = new Dictionary<int,int>();
            foreach(var i in s){
                if(d.ContainsKey(i)){
                    d[i] += 1;
                }else{
                    d.Add(i,1);
                }
            }

            var ans = d.Where(t => t.Value == 1).First().Key;
            Console.WriteLine(ans);
        }
    }
}
