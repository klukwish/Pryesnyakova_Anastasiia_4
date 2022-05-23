using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Tanker: Cargo_ship
    {
        public Tanker()
        {
            speed = 24;
            load_capacity = 500000;
            typeoffuel = "intermediate fuel oil";
            name = "Танкер";
        }
        public override string ToString()
        {
            return $"Танкер\nТип пального: {typeoffuel}";
        }
    }
}
