using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var flag = false;
            for(var i = 1; i <= 9; i++){
                for (var j = 1; j <= 9; j++){
                    if(i * j == n){
                        flag = true;
                        break;
                    }                    
                }
            }

            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
