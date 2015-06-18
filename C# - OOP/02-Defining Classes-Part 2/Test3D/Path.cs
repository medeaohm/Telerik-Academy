namespace Space3D
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pathPoints3D;

        public List<Point3D> PathPoints3D
        {
            get { return this.pathPoints3D; }
            private set { this.pathPoints3D = value; }
        }

        public Path()
        {
            this.pathPoints3D = new List<Point3D>();
        }

        public void AddNewPoint(Point3D newPoint)
        {
            pathPoints3D.Add(newPoint);
        }

        public void RemovePoint(Point3D point)
        {
            pathPoints3D.Remove(point);
        }

        public override string ToString()
        {
            return String.Join(" ", this.pathPoints3D);
        }
    }
}
