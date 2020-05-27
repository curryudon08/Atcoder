using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var s = Console.ReadLine().Trim();

            if(s.Length <= k){
                Console.WriteLine(s);
            }else{
                Console.WriteLine(s.Substring(0, k) + "...");
            }
        }
    }
}
