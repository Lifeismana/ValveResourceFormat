using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValveResourceFormat
{
    [Flags]
    public enum ModelAnimationMotionFlags
    {
        TX = 64,
        TY = 128,
        TZ = 256,
        RZ = 2048,
        Linear = 4096,
    }
}
