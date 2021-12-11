using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ToneForm
{
    public class AffineTransform
    {
        public int plus;
        public int times;

        public AffineTransform(int plusp, int timesp)
        {
            plus = plusp;
            times = timesp;
        }

        public Interval apply(Interval from)
        {
            return from.tuning.reduce(plus + times * from.steps);
        }
    }
}
