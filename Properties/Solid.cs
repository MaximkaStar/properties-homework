using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Solid
    {
        public int[] solid;

        public Solid()
        {
        }

        public Solid(int size)
        {
            solid = new int[size];
        }

      
        public int this[int index]
        {
            get
            {
                return solid[index];
            }
            set
            {
                solid[index] = value * value;
            }
        }
    }
}
