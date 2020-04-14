using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var a = int.Parse(_[1]);
            var b = int.Parse(_[2]);

            if(a - b >= 0){
                Console.WriteLine("delicious");
            }else{
                if(Math.Abs(a - b) <= x){
                    Console.WriteLine("safe");
                }else{
                    Console.WriteLine("dangerous");
                }
            }
        }
    }
}
