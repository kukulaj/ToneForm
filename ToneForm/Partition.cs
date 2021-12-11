using System;
using System.Collections.Generic;
using System.Text;

namespace ToneForm
{
    public class Partition
    {
        public Block[] blocks;
        public OrbitCover orbits;

        public Partition(OrbitCover ocp)
        {
            orbits = ocp;
            blocks = new Block[orbits.divisor];
            for(int bi = 0; bi < orbits.divisor; bi++)
            {
                blocks[bi] = new Block();
            }

            foreach (Orbit o in orbits.orbits) 
            {
                foreach (Interval i in o.intervals)
                {
                    blocks[i.index % orbits.divisor].add(i);
                }
            }
           
            for(int bi = 0; bi < orbits.divisor; bi++)
            {
                blocks[bi].write();
            }
        }
    }
}
