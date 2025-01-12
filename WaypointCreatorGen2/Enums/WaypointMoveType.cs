using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaypointCreatorGen2.Enums
{
    public enum WaypointMoveType : byte
    {
        Walk        = 0,
        Run         = 1,
        Land        = 2,
        TakeOff     = 3,

        Max
    }
}
