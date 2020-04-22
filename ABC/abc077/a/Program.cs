using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            var r1 = string.Join("",s2.Reverse()); 
            var r2 = string.Join("",s1.Reverse()); 

            if(s1.Equals(r1) && s2.Equals(r2)){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
