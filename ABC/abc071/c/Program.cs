    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace c
    {
        class Program
        {
            static void Main(string[] args)
            {
                var n = long.Parse(Console.ReadLine());
                var a = Console.ReadLine().Split().Select(i => long.Parse(i)).ToArray();

                var d = new Dictionary<long, long>();
                for(var i = 0; i < n; i++){
                    if(d.ContainsKey(a[i])){
                        d[a[i]] += 1;
                    }else{
                        d.Add(a[i], 1);
                    }
                }

                var s = d.Where(x => x.Value >= 2).OrderByDescending(x => x.Key).Take(2).ToArray();

                if(s.Any()){
                    if(s[0].Value >= 4){
                        Console.WriteLine((s[0].Key * s[0].Key));
                    }else if(s.Count() == 2){
                        Console.WriteLine((s[0].Key * s[1].Key));
                    }            
                }else{
                    Console.WriteLine(0);
                }
            }
        }
    }
