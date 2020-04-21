using System;
using System.Linq;

namespace abc086_b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine().Split().Aggregate((a,b) => a + b));
            var i = 1;
            while(true){
                var sq = i * i;
                if(sq == n){
                    Console.WriteLine("Yes");
                    break;
                }else if(sq > n){
                    Console.WriteLine("No");
                    break;
                }
                i += 1;
            }
        }
    }
}
