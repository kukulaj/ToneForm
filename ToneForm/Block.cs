using System;
using System.Collections.Generic;
using System.Text;

namespace ToneForm
{
    public class Block
    {
        public List<Interval> intervals;

        public Block ()
        {
            intervals = new List<Interval>();
        }

        public void add(Interval i)
        {
            intervals.Add(i);
        }

        public void write()
        {
            Console.Write("{");
            foreach(Interval i in intervals)
            {
                Console.Write(string.Format(" {0}", i.steps));
            }
            Console.WriteLine("}");
        }
    }
}
