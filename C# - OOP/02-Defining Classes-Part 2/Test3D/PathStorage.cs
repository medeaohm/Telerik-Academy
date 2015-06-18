namespace Space3D
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class PathStorage
    {
        public static void SavePath(Path path, string pathID)
        {
            using (StreamWriter streamWriter = new StreamWriter("..//..//" + pathID + ".txt")) 
            {
                for (int i = 0; i < path.PathPoints3D.Count; i++)
                {
                    streamWriter.Write(path.PathPoints3D[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();
            StringBuilder output = new StringBuilder();

            using (StreamReader streamReader = new StreamReader("..//..//" + filePath + ".txt"))
            {
                string[] allPoints = streamReader.ReadToEnd()
                    .Split(new char[] {'}', '{',  }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var point in allPoints)
                {
                    double[] coordinates = point.Trim('{').Trim('}')
                        .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => double.Parse(x))
                        .ToArray();

                    path.AddNewPoint(new Point3D(coordinates[0], coordinates[1], coordinates[2]));
                }
            }
            return path;
        }
    }
}
