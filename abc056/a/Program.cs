using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var a = s[0];
            var b = s[1];

            if(a.Equals("H")){
                if(b.Equals("H")){
                    Console.WriteLine("H");
                }else if(b.Equals("D")){
                    Console.WriteLine("D");
                }
            }else if(a.Equals("D")){
                if(b.Equals("H")){
                    Console.WriteLine("D");
                }else if(b.Equals("D")){
                    Console.WriteLine("H");
                }
            }
        }
    }
}
