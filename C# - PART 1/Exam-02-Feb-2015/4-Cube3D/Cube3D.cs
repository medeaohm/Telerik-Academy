using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string col = ":";
        string vl = "|";
        string minus = "-";
        int a0 = 1;
        int b0 = 1;
        int a = n;
        int b = n;
        int c = n;
        int d0 = 2;
        int d = n ;
        int e0 =3;
        int e = n+1;
       

        for (int i = 0; i < 2*n; i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < 2*n; j++)
            {
                if (i<n & j <n)
                {
                    if (i == 0)
                    {
                        Console.Write(col);
                    }
                    else if (i == n - 1)
                    {
                        Console.Write(col);
                    }
                    else if (j == 0)
                    {
                        Console.Write(col);
                    }
                    else if (j < n - 1 & j > 0)
                    {
                        Console.Write(" ");
                    }
                    else if (j == n - 1)
                    {
                        Console.Write(col);
                    }
                }
                else  if (i < 2*n -1 & j < 2*n -1)
                {
                      if (i == a0  & j == a)
                        {
                             Console.Write(col);    
                        }
                        else if (i > a0 & j > a & j < 2*n-2)
                        {
                            Console.Write(vl);
                        }
                    a++;
                    a0++;
                        //if (i == e0 & j == e & j <2*n-2)
                        //{
                        //    Console.Write(vl);
                        //    e0++;
                        //    e++;
                        //}
                        //else
                        //{
                        //    Console.Write(" ");
                        //}
                        if (i == b & j == b0)
                        {
                            Console.Write(col);
                            b0++;
                            b++;
                        }

                        //else
                        //{
                        //    Console.Write(" ");

                        //}
                        else if (i==c & j == c)
                        {
                            Console.Write(col);
                            c++;
                        }
                        else if (j==2*n-2 & i >= n)
                        {
                            Console.Write(col);
                        }
                        else if (i == 2 * n - 2 & j >= n)
                        {
                            Console.Write(col);
                        }
                      
                        //else if (i == d0 & j ==d)
                        //{
                            
                        //}
                        else
                        {
                            Console.Write(" ");

                        }
                        a0++;
                        a++;
                }

                //else if (i < n & j == a)
                //{
                //     Console.Write(col);  
                //}
                
            }




            //for (int j = 0; j < n; j++)
            //{
            //    if (i == 0)
            //    {
            //        Console.Write(col);  
            //    }
            //    else if (i % 2 == 0 & j == 0)
            //    {
            //        Console.Write(col);
            //    }
            //    else if (i%2 == 0 & j < n-1 & j > 0)
            //    {
            //        Console.Write("");
            //    }
            //    else if (i % 2 == 0 & j == n-1)
            //    {
            //        Console.Write(col);
            //    }
            //    else if (i % 2 != 0)
            //    {
            //        Console.Write("");
            //    }
            //}
            //Console.Write(col);
        }
    }
}

  //static void Main()
  //  {
  //      int bottom = int.Parse(Console.ReadLine());
  //      int width = bottom * 2 + 1;
  //      int height = 6 + ((bottom - 3) / 2) * 3;
  //      int sails = 2 * width / 3;
  //      int baseB = width / 3;

  //      string dot = ".";
  //      string star = "*";
  //      int a = (width/2) + 1;
  //      int b = (width/2) - 1;
  //      int c = 0;
  //      int d = width-1;


  //      for (int j = 0; j < width / 2; j++)
  //      {
  //          a--;
  //          b++;
  //          Console.WriteLine("");
  //          for (int i = 0; i < width; i++)
  //          {
  //              if (i < a | i > b)
  //              {
  //                  Console.Write(dot);
  //              }
  //              else if (i == a | i == b | i == width / 2)
  //              {
  //                  Console.Write(star);
  //              }
  //              else
  //              {
  //                  Console.Write(dot);
  //              }
  //          }
  //      }

  //      for (int j = width / 2; j < height; j++)
  //      {
  //          Console.WriteLine("");
  //          if (j == width / 2)
  //          {
  //              for (int l = 0; l < width; l++)
  //              {
  //                  Console.Write(star);
  //              }
  //          }
  //          else if (j == height - 1)
  //          {
  //              for (int m = 0; m < width; m++)
  //              {
  //                  if (m <= bottom - bottom / 2 - 1 | m >= width - bottom + bottom / 2)
  //                  {
  //                      Console.Write(dot);
  //                  }
  //                  else
  //                  {
  //                      Console.Write(star);
  //                  }

  //              }
  //          }

  //          else
  //          {
  //              c++;
  //              d--;
  //              for (int k = 0; k < width; k++)
  //              {
  //                  if (k < c | k > d)
  //                  {
  //                      Console.Write(dot);
  //                  }
  //                  else if (k == c | k == d | k == width / 2)
  //                  {
  //                      Console.Write(star);
  //                  }
  //                  else
  //                  {
  //                      Console.Write(dot);
  //                  }
  //              }
  //          }
  //      }
  //  }