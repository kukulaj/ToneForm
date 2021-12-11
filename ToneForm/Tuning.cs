using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ToneForm
{
    public class Tuning
    {
        public int edo;
        public Interval[] intervals;

        public Tuning(int edop)
        {
            edo = edop;

            intervals = new Interval[edo];
            for(int i=0; i< edo; i++)
            {
                intervals[i] = new Interval(this, i);
            }
        }

        public Interval reduce(int steps)
        {
            return intervals[steps % edo];
        }

        public Interval untouched()
        {
            Interval found = null;
            for(int i = 0; i < edo && found == null; i++)
            {
                if(intervals[i].orbit == null)
                {
                    found = intervals[i];
                }
            }

            return found;
        }
    }
}
