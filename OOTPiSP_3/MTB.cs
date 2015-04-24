using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    class MTB: Bicycle
    {
        public uint NumberOfSpeeds { get; set; }
        public bool isDoubleRim { get; set; }
        public bool Amortization { get; set; }
        public string Material { get; set; }

        public MTB()
        {
            this.Type = "MTB";
        }
    }
}
