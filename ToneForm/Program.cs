using System;
using System.Diagnostics;

namespace ToneForm
{
    

   

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Tuning t = new Tuning(12);
            AffineTransform f = new AffineTransform(1, 5);
            OrbitCover oc = new OrbitCover(t, f);
            Partition p = new Partition(oc);

            Console.WriteLine("Goodbye World!");
        }
    }
}
