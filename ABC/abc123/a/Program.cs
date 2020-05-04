using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new int[5];
            for(var i = 0; i < 5; i++){
                x[i] = int.Parse(Console.ReadLine());
            }
            var k = int.Parse(Console.ReadLine());

            var flag = true;
            for(var i = 0; i < 4; i++){
                for(var j = i + 1; j < 5; j++){
                    if(x[j] - x[i] > k){
                        flag = false;
                    }
                }
            }

            Console.WriteLine(flag ? "Yay!" : ":(");
        }
    }
}
