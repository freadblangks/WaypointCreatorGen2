using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WaypointCreatorGen2.Enums;

namespace WaypointCreatorGen2
{
    public class WaypointInfo
    {
        public UInt32 TimeStamp = 0;
        public WaypointPosition Position = new WaypointPosition();
        public UInt32 MoveTime = 0;
        public Int32 Delay = 0;
        public List<Vector3> SplineList = new List<Vector3>();
        public string Comment = "";
        public MoveSplineFlag SplineFlags = 0;
        public ulong? PacketNum = null;

        public WaypointInfo() { }

        public WaypointInfo(WaypointInfo rhs)
        {
            TimeStamp = rhs.TimeStamp;
            Position = new WaypointPosition(rhs.Position);
            MoveTime = rhs.MoveTime;
            Delay = rhs.Delay;
            SplineList = rhs.SplineList;
            Comment = rhs.Comment;
            SplineFlags = rhs.SplineFlags;
            PacketNum = rhs.PacketNum;
        }

        public bool IsCatmullrom() { return SplineFlags.HasFlag(MoveSplineFlag.Catmullrom); }
        public bool IsCyclic() { return SplineFlags.HasFlag(MoveSplineFlag.Cyclic); }
        public bool IsEnterCycle() { return SplineFlags.HasFlag(MoveSplineFlag.Enter_Cycle); }
    }
}
