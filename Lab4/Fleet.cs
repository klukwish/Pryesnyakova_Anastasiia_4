using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Fleet
    {
        List<Vessel> vessels = new List<Vessel>();

        public Fleet()
        {
            vessels = new List<Vessel>();
        }

        public void VesselsAdd(Vessel s)
        {
            vessels.Add(s);
        }

        public void Show()
        {
            foreach (Vessel s in vessels)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
