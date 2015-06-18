//Inside the sea (a standard Cartesian /rectangular/ coordinate system) we are given a ship S (a rectangle whose sides are parallel to the coordinate axes), a horizontal line H (the horizon) and three catapults, given as coordinates C1, C2 and C3 that will be used to fire the ship. When the attack starts, each catapult hits a projectile exactly into the positions that are symmetrical to C1, C2 and C3 with respect to the horizon H. When a projectile hits some of the corners of the ship, it causes a damage of 25%, when it hits some of the sides of the ship, the damage caused is 50% and when it hits the internal body of the ship, the damage is 100%. When the projectile hit outside of the ship, there is no damage. The total damage is sum of the separate damages and can exceed 100%.
//Your task is to write a program that calculates the total damage caused after the attack over the ship.
//Input
//The input data should be read from the console.
//There will be exactly 11 lines holding the integer numbers SX1, SY1, SX2, SY2, H, CX1, CY1, CX2, CY2, CX3, and CY3. The ship S is given by any two of its opposite corners and is non-empty (has positive width and height). The line H is given by its vertical offset. The points C1, C2 and C3 are given as couples of coordinates and cannot overap each other.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//The output should consist of a single line holding the total damage given as percentage.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ShipDamage
    {
        static void Main()
        {
            int s1x = int.Parse(Console.ReadLine());
            int s1y = int.Parse(Console.ReadLine());
            int s2x = int.Parse(Console.ReadLine());
            int s2y = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int c1x = int.Parse(Console.ReadLine());
            int c1y = int.Parse(Console.ReadLine());
            int c2x = int.Parse(Console.ReadLine());
            int c2y = int.Parse(Console.ReadLine());
            int c3x = int.Parse(Console.ReadLine());
            int c3y = int.Parse(Console.ReadLine());


            //int s1x = -11;                    
            //int s1y = 6;
            //int s2x = -6;
            //int s2y = 3;
            //int h = 1; 
            //int c1x = -9;
            //int c1y = -3;
            //int c2x = -12;
            //int c2y = -4;
            //int c3x = -6;
            //int c3y = -1;
            
            
            int c1yS = -c1y + 2*h;
            int c2yS = -c2y + 2*h;
            int c3yS = -c3y + 2*h;
            int s3x = s2x;
            int s3y = s1y;
            int s4x = s1x;
            int s4y = s2y;

            int minX = Math.Min(s1x, s2x);
            int minY = Math.Min(s1y, s2y);
            int maxX = Math.Max(s1x, s2x);
            int maxY = Math.Max(s1y, s2y);
            int damage = new int();
            bool cornerC1 = ((c1x == s1x) & (c1yS == s1y)) | ((c1x == s2x) & (c1yS == s2y)) | ((c1x == s3x) & (c1yS == s3y)) | ((c1x == s4x) & (c1yS == s4y));
            bool cornerC2 = ((c2x == s1x) & (c2yS == s1y)) | ((c2x == s2x) & (c2yS == s2y)) | ((c2x == s3x) & (c2yS == s3y)) | ((c2x == s4x) & (c2yS == s4y));
            bool cornerC3 = ((c3x == s1x) & (c3yS == s1y)) | ((c3x == s2x) & (c3yS == s2y)) | ((c3x == s3x) & (c3yS == s3y)) | ((c3x == s4x) & (c3yS == s4y));
            
            if (cornerC1)
            {
                damage = damage + 25;
            }
            if (cornerC2)
            {
                damage = damage + 25;
            }
            if (cornerC3)
            {
                damage = damage + 25;
            }

            bool sideC1 = (c1yS == s1y & c1x > minX & c1x < maxX) | (c1yS == s4y & c1x > minX & c1x < maxX) | (c1x == s1x & c1yS < maxY & c1yS > minY) | (c1yS == s2y & c1yS < maxY & c1yS > minY);
            bool sideC2 = (c2yS == s1y & c2x > minX & c2x < maxX) | (c2yS == s4y & c2x > minX & c2x < maxX) | (c2x == s1x & c2yS < maxY & c2yS > minY) | (c2yS == s2y & c2yS < maxY & c2yS > minY);
            bool sideC3 = (c3yS == s1y & c3x > minX & c3x < maxX) | (c3yS == s4y & c3x > minX & c3x < maxX) | (c3x == s1x & c3yS < maxY & c3yS > minY) | (c3yS == s2y & c3yS < maxY & c3yS > minY);

            if (sideC1)
            {
                damage = damage + 50;
            }
            if (sideC2)
            {
                damage = damage + 50;
            }
            if (sideC3)
            {
                damage = damage + 50;
            }

            bool insideC1 = c1yS < maxY & c1yS > minY & c1x > minX & c1x < maxX;
            bool insideC2 = c2yS < maxY & c2yS > minY & c2x > minX & c2x < maxX;
            bool insideC3 = c3yS < maxY & c3yS > minY & c3x > minX & c3x < maxX;

            if (insideC1)
            {
                damage = damage + 100;
            }
            if (insideC2)
            {
                damage = damage + 100;
            }
            if (insideC3)
            {
                damage = damage + 100;
            }

            Console.WriteLine("{0}%", damage);

        }
    }

