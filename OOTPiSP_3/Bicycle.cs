using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTPiSP_3
{
    public abstract class Bicycle
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public uint ReleaseDate { get; set; }
        public string Color { get; set; }
        public uint WheelsDiameter { get; set; }
        public bool isWomensBike { get; set; }       
    }
}
