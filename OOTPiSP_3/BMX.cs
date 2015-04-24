using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    class BMX: Bicycle
    {
        public string Material { get; set; }
        public uint Weight { get; set; }
        public bool isDoubleRim { get; set; }

        public BMX()
        {
            this.Type = "BMX";
        }
    }
}
