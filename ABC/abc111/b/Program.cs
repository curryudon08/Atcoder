using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());

            for(var i = x; i <= 999; i++){
                var s = Convert.ToString(i);

                if(s[0] == s[1] && s[0] == s[2]){
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
