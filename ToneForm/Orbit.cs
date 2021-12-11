using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ToneForm
{
    public class Orbit
    {
        public Interval start;
        public List<Interval> intervals;
        public AffineTransform f;
        public int length;

        public Orbit(Interval sp, AffineTransform fp)
        {
            start = sp;
            f = fp;
            intervals = new List<Interval>();

            Interval i = start;
            int x = 0;
            while(i.orbit == null)
            {
                intervals.Add(i);
                i.orbit = this;
                i.index = x;
                x++;
                i = f.apply(i);
            }
            Debug.Assert(i == start);
            length = x;
        }
    }
}
