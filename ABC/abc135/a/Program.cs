using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = long.Parse(_[0]);
            var b = long.Parse(_[1]);

            if((a + b) % 2 == 0){
                Console.WriteLine((a + b) / 2);
            }else{
                Console.WriteLine("IMPOSSIBLE");
            }
        }
    }
}
