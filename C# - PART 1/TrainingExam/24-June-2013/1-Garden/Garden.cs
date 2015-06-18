using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Garden
    {
        static void Main()
        {
            int tomatoS = int.Parse(Console.ReadLine());
            int tomatoA = int.Parse(Console.ReadLine());
            int cucumberS = int.Parse(Console.ReadLine());
            int cucumberA = int.Parse(Console.ReadLine());
            int potatoS = int.Parse(Console.ReadLine());
            int potatoA = int.Parse(Console.ReadLine());
            int carrotS = int.Parse(Console.ReadLine());
            int carrotA = int.Parse(Console.ReadLine());
            int cabbageS = int.Parse(Console.ReadLine());
            int cabbageA = int.Parse(Console.ReadLine());
            int beansS = int.Parse(Console.ReadLine());

            int area = tomatoA + cucumberA + potatoA + carrotA + cabbageA;
            double cost = tomatoS * 0.5 + cucumberS * 0.4 + potatoS * 0.25 + carrotS * 0.6 + cabbageS * 0.3 + beansS * 0.4;

            if (area < 250)
            {
                Console.WriteLine("Total costs: {0:0.00}", cost);
                int beansA = 250 - area;
                Console.WriteLine("Beans area: {0}", beansA);
            }

            else if (area == 250)
            {
                Console.WriteLine("Total costs: {0:0.00}", cost);
                Console.WriteLine("No area for beans");
            }
            else if (area > 250)
            {
                Console.WriteLine("Total costs: {0:0.00}", cost);
                Console.WriteLine("Insufficient area");
            }

        }
    }
