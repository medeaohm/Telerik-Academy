//### Problem 12. Subtracting polynomials
//*	Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;
using System.Text;

class SubtractingPolynomials
{
    static void Main()
    {
        Console.Write("Please insert the degree of the first polinomial... N = ");
        int n1 = int.Parse(Console.ReadLine());
        int[] pol1 = PolinomialAsArray(n1);
        Console.WriteLine("The first polinomial is...");
        for (int i = n1; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{1}*x^{0} + ", i, pol1[i]);
            }
            else
            {
                Console.Write("{1}*x^{0} ", i, pol1[i]);
            }
        }
        Console.WriteLine("\n");

        Console.Write("Please insert the degree of the second polinomial... N = ");
        int n2 = int.Parse(Console.ReadLine());
        int[] pol2 = PolinomialAsArray(n2);
        Console.WriteLine("The second polinomial is...");
        for (int i = n2; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{1}*x^{0} + ", i, pol2[i]);
            }
            else
            {
                Console.Write("{1}*x^{0} ", i, pol2[i]);
            }
        }
        Console.WriteLine("\n");


        int length = CheckLenght(n1, n2);
        int[] sum = AddPolinomials(pol1, pol2, length);
        Console.WriteLine("The sum is...");
        for (int i = length; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{1}*x^{0} + ", i, sum[i]); 
            }
            else
            {
                Console.Write("{1}*x^{0} ", i, sum[i]);
            }
        }
        Console.WriteLine("\n");

        int[] diff = SubstractPolinomials(pol1, pol2, length);
        Console.WriteLine("The difference is...");
        for (int i = length; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{1}*x^{0} + ", i, diff[i]);
            }
            else
            {
                Console.Write("{1}*x^{0} ", i, diff[i]);
            }
        }
        Console.WriteLine("\n");

        int[] multipl = MultiplicationPolinomials(pol1, pol2, length);
        Console.WriteLine("The multiplication is...");
        for (int i = length; i >= 0; i--)
        {
            if (i != 0)
            {
                Console.Write("{1}*x^{0} + ", i, multipl[i]);
            }
            else
            {
                Console.Write("{1}*x^{0} ", i, multipl[i]);
            }
        }
        Console.WriteLine();
    }

    private static int[] PolinomialAsArray(int degree)
    {
        int[] polinomial = new int[degree + 1];
        for (int i = degree; i >= 0; i--)
			{
            Console.Write("x^{0} = ", i);
			 polinomial[i] = int.Parse(Console.ReadLine());
			}
        return polinomial;
    }

    private static int CheckLenght (int degree1, int degree2)
    {
        int length = degree2;
        if (degree1 > degree2)
	    {
            length = degree1;
	    }
        return length;
    }


    private static int[] AddPolinomials(int[] pol1, int[] pol2, int length)
    {
        int[] sumPol = new int[length+1];
        int[] newPol1 = new int[length+1];
        int[] newPol2 = new int[length+1];
        if(pol1.Length < pol2.Length)
	    {
		    for (int i = length; i >= 0; i--)
			{
                newPol2[i] = pol2[i];
			    if (i >= pol1.Length)
	            {
		            newPol1[i] = 0; 
	            }
                else
	            {
                    newPol1[i] = pol1[i];
	            }
			}
	    }
        else if(pol1.Length > pol2.Length)
	    {
		    for (int i = length; i >= 0; i--)
			{
                newPol1[i] = pol1[i];
			    if (i >= pol2.Length)
	            {
		            newPol2[i] = 0; 
	            }
                else
	            {
                    newPol2[i] = pol2[i];
	            }
			}
	    }
        else
	    {
            newPol1 = pol1;
            newPol2 = pol2;
	    }

        for (int i = length; i >= 0; i--)
		{
			sumPol[i] = newPol1[i] + newPol2[i];
		}
        return sumPol;
    }

    private static int[] SubstractPolinomials(int[] pol1, int[] pol2, int length)
    {
        int[] subsPol = new int[length + 1];
        int[] newPol1 = new int[length + 1];
        int[] newPol2 = new int[length + 1];
        if (pol1.Length < pol2.Length)
        {
            for (int i = length; i >= 0; i--)
            {
                newPol2[i] = pol2[i];
                if (i >= pol1.Length)
                {
                    newPol1[i] = 0;
                }
                else
                {
                    newPol1[i] = pol1[i];
                }
            }
        }
        else if (pol1.Length > pol2.Length)
        {
            for (int i = length; i >= 0; i--)
            {
                newPol1[i] = pol1[i];
                if (i >= pol2.Length)
                {
                    newPol2[i] = 0;
                }
                else
                {
                    newPol2[i] = pol2[i];
                }
            }
        }
        else
        {
            newPol1 = pol1;
            newPol2 = pol2;
        }

        for (int i = length; i >= 0; i--)
        {
            subsPol[i] = newPol1[i] - newPol2[i];
        }
        return subsPol;
    }

    private static int[] MultiplicationPolinomials(int[] pol1, int[] pol2, int length)
    {
        int[] multPol = new int[length + 1];
        int[] newPol1 = new int[length + 1];
        int[] newPol2 = new int[length + 1];
        if (pol1.Length < pol2.Length)
        {
            for (int i = length; i >= 0; i--)
            {
                newPol2[i] = pol2[i];
                if (i >= pol1.Length)
                {
                    newPol1[i] = 0;
                }
                else
                {
                    newPol1[i] = pol1[i];
                }
            }
        }
        else if (pol1.Length > pol2.Length)
        {
            for (int i = length; i >= 0; i--)
            {
                newPol1[i] = pol1[i];
                if (i >= pol2.Length)
                {
                    newPol2[i] = 0;
                }
                else
                {
                    newPol2[i] = pol2[i];
                }
            }
        }
        else
        {
            newPol1 = pol1;
            newPol2 = pol2;
        }

        for (int i = length; i >= 0; i--)
        {
            multPol[i] = newPol1[i] * newPol2[i];
        }
        return multPol;
    }
}

