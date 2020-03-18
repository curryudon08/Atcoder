using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var s = Console.ReadLine();

            if(n % 2 == 0){
                var i = n / 2;
                var t = string.Join("",s.Take(i));
                if(s.Equals(t + t)){
                    Console.WriteLine("Yes");
                }else{
                    Console.WriteLine("No");
                }
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
