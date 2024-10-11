using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WaypointCreatorGen2.Spline
{
    public static class CatmullRom
    {
        public static float SplineInterpolation(float P0, float P1, float P2, float P3, float t)
        {
            return 0.5f * (2 * P1 +
                            (-P0 + P2) * t +
                            (2 * P0 - 5 * P1 + 4 * P2 - P3) * t * t +
                            (-P0 + 3 * P1 - 3 * P2 + P3) * t * t * t);
        }

        public static List<Vector3> CalcSpline(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, int numPoints)
        {
            List<Vector3> points = new List<Vector3>();
            for (int i = 0; i <= numPoints; i++)
            {
                float t = (float)i / numPoints;

                float x = SplineInterpolation(P0.X, P1.X, P2.X, P3.X, t);
                float y = SplineInterpolation(P0.Y, P1.Y, P2.Y, P3.Y, t);
                float z = SplineInterpolation(P0.Z, P1.Z, P2.Z, P3.Z, t);

                points.Add(new Vector3(x, y, z));
            }
            return points;
        }

        public static float CalculateSpeed(uint moveTimeMs, List<Vector3> points)
        {
            int numSamplePoints = 10;
            List<Vector3> allSplinePoints = new List<Vector3>();

            for (int i = 1; i < points.Count - 2; i++)
            {
                var segmentPoints = CalcSpline(points[i - 1], points[i], points[i + 1], points[i + 2], numSamplePoints);
                allSplinePoints.AddRange(segmentPoints);
            }

            float totalDistanceSpline = 0;
            for (int i = 0; i < allSplinePoints.Count - 1; i++)
            {
                totalDistanceSpline += Vector3.Distance(allSplinePoints[i], allSplinePoints[i + 1]);
            }

            float moveTimeSec = (float)moveTimeMs / 1000;

            return totalDistanceSpline / moveTimeSec;
        }
    }
}
