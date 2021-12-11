using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ToneForm
{
    public class Interval
    {
        public int steps;
        public Tuning tuning;
        public Orbit orbit;
        public int index;
        public int assignment;

        public Interval(Tuning tp, int sp)
        {
            steps = sp;
            tuning = tp;
        }
    }
}
