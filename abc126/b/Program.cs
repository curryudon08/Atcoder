using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var a = int.Parse(s.Substring(0,2));
            var b = int.Parse(s.Substring(2,2));

            if((1 <= a && a <= 12) && (1 <= b && b <= 12)){
                Console.WriteLine("AMBIGUOUS");
            }else if(1 <= b && b <= 12){
                Console.WriteLine("YYMM");
            }else if(1 <= a && a <= 12){
                Console.WriteLine("MMYY");
            }else{
                Console.WriteLine("NA");
            }
        }
    }
}
