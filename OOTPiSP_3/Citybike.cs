using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    class CityBike: Bicycle
    {
        public bool isFolding { get; set; }
        public bool isSeatAmortiazation { get; set; }

        public CityBike()
        {
            this.Type = "City bike";
        }
    }
}
