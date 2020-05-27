using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            var x = 0;
            foreach(var c in s){
                if(c == 'o'){
                    x += 1;
                }
            }

            Console.WriteLine(x * 100 + 700);
        }
    }
}
