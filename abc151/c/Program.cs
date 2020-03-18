using System;
using System.Collections.Generic;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Console.ReadLine().Split();
            var n = int.Parse(r[0]);
            var m = int.Parse(r[1]);

            var d = new Dictionary<int ,string>();
            var e = new Dictionary<int ,int>();
            for(var i = 0; i < m; i++){
                var t = Console.ReadLine().Split();
                var p = int.Parse(t[0]);
                var s = t[1];

                if(d.ContainsKey(p)){
                    if(d[p].Equals("AC")){
                        continue;
                    }else{
                        d[p] = s;
                        if(s.Equals("WA")){
                            e[p] += 1;
                        }
                    }
                }else{
                    d.Add(p, s);
                    e.Add(p, 0);
                    if(s.Equals("WA")){
                        e[p] += 1;
                    }                    
                }
            }

            var ac = d.Count(x => x.Value == "AC");
            var wa = e.Where(x => d[x.Key].Equals("AC")).Sum(x => x.Value);
            Console.WriteLine(string.Format("{0} {1}",ac,wa));
        }
    }
}
