using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Trim();
            var n = int.Parse(Console.ReadLine());

            var isReverse = false;
            var head = new List<string>();
            var tail = new List<string>();

            foreach(var i in Enumerable.Range(0, n)){
                var q = Console.ReadLine().Split().ToArray();

                if(q[0].Equals("1")){
                    isReverse = !isReverse;
                }else{
                    if(isReverse){
                        if(q[1].Equals("1")){
                            tail.Add(q[2]);
                        }else{
                            head.Add(q[2]);
                        }
                    }else{
                        if(q[1].Equals("1")){
                            head.Add(q[2]);
                        }else{
                            tail.Add(q[2]);
                        }
                    }
                }
            }

            head.Reverse();
            var x = head.Count > 0 ? string.Join("",head) : "";
            var y = string.Join("",s);
            var z = tail.Count > 0 ? string.Join("",tail) : "";
            var ans = isReverse ? string.Join("",(x + y + z).Reverse()) : x + y + z;

            Console.WriteLine(ans);
        }
    }
}
