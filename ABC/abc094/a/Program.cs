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
            var x = int.Parse(_[2]);

            if(a > x){
                Console.WriteLine("NO");
            }else{
                x -= a;
                if(x <= b){
                    Console.WriteLine("YES");
                }else{
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
