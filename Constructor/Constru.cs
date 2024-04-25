using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Constru
    {
        public int id;
        public String name;
        public Constru(int id)
        {
          //  this(2, "hfggh");
            this.id = id;
        }
        public Constru(int id, string name )
        {
            this.id = id;
            this.name = name;
        }
    }
}
