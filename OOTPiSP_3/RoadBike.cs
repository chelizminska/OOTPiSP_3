using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    class RoadBike: Bicycle
    {
        public uint NumberOfSpeeds { get; set; }
        public bool isPumpKit { get; set; }

        public RoadBike()
        {
            this.Type = "Road bike";
        }
    }
}
