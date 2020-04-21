using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var g1 = new int[]{1,3,5,7,8,10,12};
            var g2 = new int[]{4,6,9,11};
            var g3 = new int[]{2};
            
            var _ = Console.ReadLine().Split();
            var x = int.Parse(_[0]);
            var y = int.Parse(_[1]);

            var flag = false;
            if(g1.Contains(x) && g1.Contains(y)){
                flag = true;
            }
            if(g2.Contains(x) && g2.Contains(y)){
                flag = true;
            }
            if(g3.Contains(x) && g3.Contains(y)){
                flag = true;
            }

            Console.WriteLine(flag ? "Yes" : "No");
        }
    }
}
