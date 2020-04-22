using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().ToCharArray();
            var x = Convert.ToInt32(_[0]);
            var y = Convert.ToInt32(_[2]);

            if(x < y){
                Console.WriteLine("<");
            }else if(x > y){
                Console.WriteLine(">");
            }else{
                Console.WriteLine("=");
            }
        }
    }
}
