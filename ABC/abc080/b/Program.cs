using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var total = n.ToCharArray().Select(i => long.Parse(i.ToString())).Sum();

            if(long.Parse(n) % total == 0){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
