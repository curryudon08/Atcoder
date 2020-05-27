using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var r = n % 10;

            if(r == 2 || r == 4 || r == 5 || r == 7 || r == 9){
                Console.WriteLine("hon");
            }else if(r == 3){
                Console.WriteLine("bon");
            }else{
                Console.WriteLine("pon");
            }
        }
    }
}
