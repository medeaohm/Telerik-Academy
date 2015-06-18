using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Maslan
{
    static void Main()
    {
        string n = Console.ReadLine();
  
        for (int m = 0; m < 10; m++)
        {
            int nL = n.Length;
            string[] num = new string[nL];
            int[] sum = new int[nL];
            int sum0 = 0;
            int product = 1;
            string prod2;
            
            for (int i = 0; i < nL; i++)
            {
                num[i] = n.Substring(0, (n.Length - i));
        
            }
            int[] lengthI = new int[nL];
            for (int i = 1; i < nL; i++)
            {
                lengthI[i] = num[i].Length;
                // Console.WriteLine(lengthI[i]);
                for (int j = 0; j < lengthI[i]; j++)
                {
                    if (j % 2 != 0)
                    {
                        sum0 += int.Parse(num[i].Substring(j, 1));
                    }
                }
                sum[i] = sum0;
                sum0 = 0;
            }
            for (int i = 0; i < nL; i++)
            {
                if (sum[i] != 0)
                {
                    product *= sum[i];
                }
            }
  
            string prod = product.ToString();
            prod2 = prod.Substring(1, prod.Length - 1);
       
            n = prod2;
            if (prod2.Length < 2)
            {
                Console.WriteLine(m);
                Console.WriteLine(n);
            }

            else if (m == 9)
            {

                Console.WriteLine("{0}", prod2);
            }
        } 
        
      
       
    }
}

