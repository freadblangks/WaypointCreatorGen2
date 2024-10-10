using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaypointCreatorGen2
{
    public class WaypointPosition
    {
        public float PositionX = 0f;
        public float PositionY = 0f;
        public float PositionZ = 0f;
        public float? Orientation;

        public WaypointPosition() { }

        public WaypointPosition(WaypointPosition rhs)
        {
            PositionX = rhs.PositionX;
            PositionY = rhs.PositionY;
            PositionZ = rhs.PositionZ;
            Orientation = rhs.Orientation;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            WaypointPosition otherPosition = (WaypointPosition)obj;
            return PositionX == otherPosition.PositionX &&
                   PositionY == otherPosition.PositionY &&
                   PositionZ == otherPosition.PositionZ;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + PositionX.GetHashCode();
            hash = hash * 23 + PositionY.GetHashCode();
            hash = hash * 23 + PositionZ.GetHashCode();
            return hash;
        }

        public float GetEuclideanDistance(WaypointPosition pos)
        {
            float deltaX = PositionX - pos.PositionX;
            float deltaY = PositionY - pos.PositionY;
            float deltaZ = PositionZ - pos.PositionZ;

            float distanceSquared = deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ;

            return (float)Math.Sqrt(distanceSquared);
        }
    }
}
