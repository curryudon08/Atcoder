using System;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var d = new Dictionary<long, long>();

            for(var i = 1; i <= n; i++){
                var a = long.Parse(Console.ReadLine());
                d.Add(i, a);
            }

            var flag = false;
            var count = 0;
            var key = 1L;
            while(true){
                if(d.ContainsKey(key)){
                    count++;
                    var item = d[key];
                    if(item == 2){
                        flag = true;
                        break;
                    }
                    d.Remove(key);
                    key = item;
                }else{
                    break;
                }
            }

            Console.WriteLine(flag ? count : -1);
        }
    }
}
