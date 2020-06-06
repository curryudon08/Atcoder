using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var _ = Console.ReadLine().Split('/');
            var y = int.Parse(_[0]);
            var m = int.Parse(_[1]);
            var d = int.Parse(_[2]);
            var s = new DateTime(y,m,d);

            var t = new DateTime(2019,4,30);
            Console.WriteLine(t.Date >= s.Date ? "Heisei" : "TBD");
        }
    }
}
