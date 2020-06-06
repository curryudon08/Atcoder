using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(i => int.Parse(i)).ToArray();

            var count = 0;
            while(a.Any(x => x > 0)){
                for(var i = 0; i < n; i++){
                    if(a[i] != 0){
                        count++;
                        while(i < n){
                            if(a[i] == 0){
                                break;
                            }
                            a[i]--;
                            i++;
                        }
                    }
                }

            }

            Console.WriteLine(count);
        }
    }
}
