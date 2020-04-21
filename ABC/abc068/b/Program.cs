using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var count = int.MinValue;
            var ans = 0;
            for(var i = 1; i <= n; i++){
                var x = i;
                var c = 0;
                while(x % 2 == 0){
                    x /= 2;
                    c++;
                }
                if(c > count){
                    count = c;
                    ans = i;
                }
            }

            Console.WriteLine(ans);
        }
    }
}
