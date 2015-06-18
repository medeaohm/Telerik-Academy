namespace Space3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D origin;

        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }


        private static Point3D Origin
        {
            get { return origin; }
        }

        public Point3D(double x, double y, double z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        static Point3D()
        {
            origin = new Point3D(0, 0, 0);
        }


        public double X
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            private set { this.z = value; }
        }

        public override string ToString()
        {
            return String.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
        }
    }
}
