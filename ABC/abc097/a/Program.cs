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
            var c = int.Parse(_[2]);
            var d = int.Parse(_[3]);

            if(Math.Abs(c - a) <= d){
                Console.WriteLine("Yes");
            }else if(Math.Abs(c- b) <= d && Math.Abs(b - a) <= d){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
