using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var l = long.Parse(_[0]);
            var r = long.Parse(_[1]);

            var mod = 2018;
            if(r - l >= 2019 * 2){
                mod = 0;
            }else{
                for(var i = l; i < r; i++){
                    for(var j = i + 1; j <= r; j++){
                        var n = (i * j) % 2019;
                        mod = Math.Min(mod, (int)n);
                    }
                }
            }

            Console.WriteLine(mod);
        }
    }
}
