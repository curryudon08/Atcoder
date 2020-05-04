using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var count = 1;
            for(var i = 0; i < n; i++){
                if(count * 2 > count + k){
                    count += k;
                }else{
                    count *= 2;
                }
            }

            Console.WriteLine(count);
        }
    }
}
