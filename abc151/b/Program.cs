using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var n = int.Parse(s[0]);
            var k = int.Parse(s[1]);
            var m = int.Parse(s[2]);
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).Sum();

            var x = m * n - a;
            if(x > k){
                Console.WriteLine(-1);
            }else{
                Console.WriteLine(x >= 0 ? x : 0);
            }
        }
    }
}
