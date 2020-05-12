using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = int.Parse(Console.ReadLine());

            if(s == 7 || s == 5 || s == 3){
                Console.WriteLine("YES");
            }else{
                Console.WriteLine("NO");
            }
        }
    }
}
