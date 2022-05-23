using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Vessel
    {
        public int speed { get; set; }

        public string typeoffuel { get; set; }

        public abstract void Move();

        public abstract void FuelCount();
    }
}
