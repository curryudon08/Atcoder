using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split();
            var a = int.Parse(s[0]);
            var b = int.Parse(s[1]);

            var sa = new string(Convert.ToChar(a.ToString()), b);
            var sb = new string(Convert.ToChar(b.ToString()), a);
            if(sa.CompareTo(sb) < 0){
                Console.WriteLine(sa);
            }else{
                Console.WriteLine(sb);
            }
        }
    }
}
