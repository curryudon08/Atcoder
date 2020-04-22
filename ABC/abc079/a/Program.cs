using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().ToCharArray();

            var flag = false;
            for(var i = 0; i < 2; i++){
                if(n[i] == n[i + 1] && n[i] == n[i+2]){
                    flag = true;
                    break;
                }
            }

            if(flag){
                Console.WriteLine("Yes");
            }else{
                Console.WriteLine("No");
            }
        }
    }
}
