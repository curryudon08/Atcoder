using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Convert.ToChar(Console.ReadLine());
            
            if(s == 'A'){
                Console.WriteLine("T");
            }

            if(s == 'T'){
                Console.WriteLine("A");
            }

            if(s == 'C'){
                Console.WriteLine("G");
            }

            if(s == 'G'){
                Console.WriteLine("C");
            }
        }
    }
}
