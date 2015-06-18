namespace Space3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    class Test
    {
        static void Main(string[] args)
        {
            Point3D p = new Point3D();
            Point3D q = new Point3D(1, 2, 3);
            Console.WriteLine("First Point = {0}", p.ToString());
            Console.WriteLine("Second Point = {0}", p.ToString());
            Console.WriteLine("\nDistance: {0:F4}", EuclideanDistance.Distance(p, q));

            Path path = new Path();
            path.AddNewPoint(p);
            path.AddNewPoint(q);

            Console.WriteLine("\nSaving the path in the file PathToTxt.txt ... ");


            PathStorage.SavePath(path, "firstPath");
            Console.WriteLine("\nReading the file PathToTxt.txt ... \n{0}\n", PathStorage.LoadPath("firstPath"));        
        }
    }
}
