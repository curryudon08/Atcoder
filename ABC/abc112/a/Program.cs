using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if(n == 1){
                Console.WriteLine("Hello World");
            }else{
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                Console.WriteLine(a + b);
            }
        }
    }
}
