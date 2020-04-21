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

            if(a >= 13){
                Console.WriteLine(b);
            }else if(a >= 6 && a <= 12){
                Console.WriteLine(b / 2);
            }else{
                Console.WriteLine(0);
            }
        }
    }
}
