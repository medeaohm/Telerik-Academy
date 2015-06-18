using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_BombingCuboids
{
    class BombingCuboids
    {
        static int width, height, depth;
        static char[, ,] cuboid;
        static readonly int[] cubesDestroyed = new int['Z' - 'A' + 1];

        private const char EmptyCell = '-';

        static void Main()
        {
            ReadCuboids();
            DetonateBombsAndFallDown();
            PrintResults();
        }

        private static void ReadCuboids()
        {
            string whd = Console.ReadLine();
            string[] whdCub = whd.Split();
            width = int.Parse(whdCub[0]);
            height = int.Parse(whdCub[1]);
            depth = int.Parse(whdCub[2]);

            cuboid = new char[width, height, depth];

            for (int h = 0; h < height; h++)
            {
                string line = Console.ReadLine();
                string[] letters = line.Split();
                for (int d = 0; d < depth; d++)
                {
                    for (int w = 0; w < width; w++)
                    {
                        cuboid[w, h, d] = letters[d][w];
                    }
                }
            }
        }

        private static void DetonateBombsAndFallDown()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] coordinates = line.Split(' ');
                int w = int.Parse(coordinates[0]);
                int h = int.Parse(coordinates[1]);
                int d = int.Parse(coordinates[2]);
                int p = int.Parse(coordinates[3]);
                DetonateBombs(w, h, d, p);
                FallDown(w, d, p);
            }
        }

        private static void DetonateBombs(int wPos, int hPos, int dPos, int power)
        {
            int startW = Math.Max(0, wPos - power);
            int endW = Math.Min(wPos + power, width - 1);
            for (int w = startW; w <= endW; w++)
            {
                int startH = Math.Max(0, hPos - power);
                int endH = Math.Min(hPos + power, height - 1);
                for (int h = startH; h < endH; h++)
                {
                    int startD = Math.Max(0, dPos - power);
                    int endD = Math.Min(dPos + power, depth - 1);
                    for (int d = startD; d < endD; d++)
                    {
                        double distance = CalcEuclideanDistance(w, h, d, wPos, hPos, dPos);
                        if (distance <= power)
                        {
                            char cubeColor = cuboid[w, h, d];
                            if (cubeColor != EmptyCell)
                            {
                                cubesDestroyed[cubeColor - 'A']++;
                            }
                            cuboid[w, h, d] = EmptyCell;
                        }
                    }
                }
            }
        }

        private static double CalcEuclideanDistance(int w, int h, int d, int wPos, int hPos, int dPos)
        {
            double dist = Math.Sqrt(
                (w - wPos) * (w - wPos) +
                (h - hPos) * (h - hPos) +
                (d - dPos) * (d - dPos));

            return dist;
        }


        private static void FallDown(int wPos, int dPos, int p)
        {
            int startW = Math.Max(0, wPos - p);
            int endW = Math.Min(wPos + p, width);
            for (int w = startW; w < endW; w++)
            {
                int startD = Math.Max(0, dPos - p);
                int endD = Math.Min(dPos + p, depth);
                for (int d = startD; d < endD; d++)
                {
                    FallDown(w, d);
                }
            }
        }

        private static void FallDown(int w, int d)
        {
            int startH = 0;
            while ((startH < height) && cuboid[w,startH,d] != EmptyCell)
            {
                startH++;
            }
            if (startH < height - 1)
            {
                int cubeH = startH + 1;
                while ((cubeH < height) && cuboid[w, cubeH, d] == EmptyCell)
                {
                    cubeH++;
                }
                while (cubeH < height)
                {
                    cuboid[w, startH, d] = cuboid[w, cubeH, d];
                    cuboid[w, cubeH, d] = EmptyCell;
                    cubeH++;
                    startH++;
                }
            }
        }
        private static void PrintResults()
        {
            int cubesDestroyedCount = 0;
            for (int i = 0; i < cubesDestroyed.Length; i++)
            {
                cubesDestroyedCount += cubesDestroyed[i];
            }
            Console.WriteLine(cubesDestroyedCount);

            for (char color = 'A'; color <= 'Z'; color++)
            {
                int count = cubesDestroyed[color - 'A'];
                if (count > 0)
                {
                    Console.WriteLine("{0} {1}", color, count);
                }
            }
        }
    }
}
