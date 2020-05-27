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

            for(var i = 0; i < 16; i++){
                if(a <= 0 && b <= 0){
                    break;
                }
                if(i % 2 == 0){
                    a--;
                }else{
                    b--;
                }
            }

            Console.WriteLine(a <= 0 && b <= 0 ? "Yay!" : ":(");
        }
    }
}
