using System;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var d = new Dictionary<string,int>();
            var p = Console.ReadLine();
            d.Add(p,1);

            var f = true;
            for(var i = 1; i < n; i++){
                var s = Console.ReadLine();
                if(d.ContainsKey(s)){
                    f = false;
                }else{
                    d.Add(s,1);
                }

                if(p[p.Length-1] != s[0]){
                    f = false;
                }
                p = s;
            }

            Console.WriteLine(f ? "Yes" : "No");
        }
    }
}
