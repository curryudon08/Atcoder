using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split().Select(i => long.Parse(i)).Select(i => i == 1 ? 1 + 13 : i).ToArray();
            var a = s[0];
            var b = s[1];

            if(a == b){
                Console.WriteLine("Draw");
            }else if(a > b){
                Console.WriteLine("Alice");
            }else{
                Console.WriteLine("Bob");
            }
        }
    }
}
