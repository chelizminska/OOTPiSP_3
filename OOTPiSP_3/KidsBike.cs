using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    class KidsBike: Bicycle
    {
        public bool isFolding { get; set; }
        public bool isAdditionalWheels { get; set; }
        public uint Weight { get; set; }

        public KidsBike()
        {
            this.Type = "Kids bike";
        }
    }
}
