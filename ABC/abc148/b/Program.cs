using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var line = Console.ReadLine().Split(); 
            var s = line[0];
            var t = line[1];

            var str = string.Join("",Enumerable.Range(0,n).Select(i => s[i].ToString() + t[i].ToString()));
            Console.WriteLine(str);
        }
    }
}
