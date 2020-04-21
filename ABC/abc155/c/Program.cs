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

            var d = new Dictionary<string, int>();
            var maxValue = 0;
            foreach(var i in Enumerable.Range(0,n)){
                var s = Console.ReadLine().Trim();
                if(!d.ContainsKey(s)){
                    d.Add(s, 1);
                }else{
                    d[s] += 1;
                }
                maxValue = Math.Max(maxValue, d[s]);
            }

            var l = new List<string>();
            foreach(var item in d){
                if(item.Value == maxValue){
                    l.Add(item.Key);
                }
            }

            l.Sort(StringComparer.OrdinalIgnoreCase);
            foreach(var str in l){
                Console.WriteLine(str);
            }
        }
    }
}
