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

            if(b >= a){
                Console.WriteLine(a);
            }else{
                Console.WriteLine(a - 1);
            }
        }
    }
}
