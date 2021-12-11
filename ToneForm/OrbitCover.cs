using System;
using System.Collections.Generic;
using System.Text;

namespace ToneForm
{
    public class OrbitCover
    {
        public List<Orbit> orbits;
        public AffineTransform f;
        public Tuning tuning;
        public int divisor;

        private int gcd(int a, int b)
        {
            int small;
            int big;
            if(a > b)
            {
                big = a;
                small = b;
            }
            else
            {
                big = b;
                small = a;
            }

            while (small > 0)
            {
                int swap = big % small;
                big = small;
                small = swap;
            }
            return big;
        }
        public OrbitCover(Tuning tp, AffineTransform fp)
        {
            tuning = tp;
            f = fp;

            orbits = new List<Orbit>();

            bool first = true;
            while(true)
            {
                Interval start = tuning.untouched();
                if(start == null) 
                {
                    break;
                }

                Orbit orbit = new Orbit(start, f);
                orbits.Add(orbit);
                if(first)
                {
                    divisor = orbit.length;
                    first = false;
                }
                else
                {
                    divisor = gcd(divisor, orbit.length);
                }
            }

            Console.Write("orbit cover ");
            Console.Write(string.Format("for tuning {0} ", tuning.edo));
            Console.Write(string.Format("and transform {0} + {1}*s ", f.plus, f.times));
            Console.WriteLine(string.Format("has {0} orbits with gcd {1}", orbits.Count, divisor));
        }
    }
}
