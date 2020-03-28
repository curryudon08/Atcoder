using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var _  = Console.ReadLine().Split();
            var n = int.Parse(_[0]);
            var d = int.Parse(_[1]);

            var l = new List<int[]>();
            for(var i = 0; i < n; i++){
                var ary = Console.ReadLine().Split().Select(t => int.Parse(t)).ToArray();
                l.Add(ary);
            }

            var count = 0;
            for(var i = 0; i < n - 1; i++){
                for(var j = i + 1; j < n; j++){
                    var y = l[i];
                    var z = l[j];
                    var distance = 0.0;
                    for(var k = 0; k < d; k++){
                        distance += ((y[k] - z[k]) * (y[k] - z[k]));
                    }
                    distance = Math.Sqrt(distance);
                    
                    if(distance - Math.Floor(distance) == 0){
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
