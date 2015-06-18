namespace Space3D
{
    using System;

    public static class EuclideanDistance
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(Math.Pow((firstPoint.x - secondPoint.x), 2) + Math.Pow((firstPoint.y - secondPoint.y), 2) + Math.Pow((firstPoint.z - secondPoint.z), 2));
        }
    }
}
