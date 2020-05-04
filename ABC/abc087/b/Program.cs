using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            var count = 0;
            for(var i = 0; i <= a; i++){
                for(var j = 0; j <= b; j++){
                    for(var k = 0; k <= c; k++){
                        var t = (500 * i) + (100 * j) + (50 * k);
                        count += t == x ? 1 : 0;
                    }                
                }
            }

            Console.WriteLine(count);
        }
    }
}
