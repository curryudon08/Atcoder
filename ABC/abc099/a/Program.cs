using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if(n <= 999){
                Console.WriteLine("ABC");
            }else{
                Console.WriteLine("ABD");
            }
        }
    }
}
