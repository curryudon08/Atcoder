using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var a = int.Parse(_[0]);
            var b = int.Parse(_[1]);

            if(a % 3 == 0 || b % 3 == 0 || (a + b) % 3 == 0){
                Console.WriteLine("Possible");
            }else{
                Console.WriteLine("Impossible");
            }
        }
    }
}
