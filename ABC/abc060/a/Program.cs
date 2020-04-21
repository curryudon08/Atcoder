using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var a = s[0].ToCharArray();
            var b = s[1].ToCharArray();
            var c = s[2].ToCharArray();

            if(a.Last() == b.First() && b.Last() == c.First()){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
