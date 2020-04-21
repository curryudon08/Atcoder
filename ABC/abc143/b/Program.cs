using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var d = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var total = 0;
            for(var i = 0; i < n-1; i++){
                for(var j = i+1; j < n; j++){
                    var x = d[i];
                    var y = d[j];
                    total += (x * y);
                }
            }

            Console.WriteLine(total);
        }
    }
}
