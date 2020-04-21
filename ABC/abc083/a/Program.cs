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

            var left = a + b;
            var right = c + d;

            if(left > right){
                Console.WriteLine("Left");
            }else if(left < right){
                Console.WriteLine("Right");
            }else{
                Console.WriteLine("Balanced");
            }
        }
    }
}
