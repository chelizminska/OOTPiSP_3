using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    class Hybrid: Bicycle
    {
        public uint NumberOfSpeeds { get; set; }
        public string Material { get; set; }
        public uint BusWidth { get; set; }

        public Hybrid()
        {
            this.Type = "Hubrid";
        }
    }
}
