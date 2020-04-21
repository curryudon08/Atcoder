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

            if(a <= 9 && b <= 9){
                Console.WriteLine(a * b);
            }else{
                Console.WriteLine(-1);
            }
        }
    }
}
