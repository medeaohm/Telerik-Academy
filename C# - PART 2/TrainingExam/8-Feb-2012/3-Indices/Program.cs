using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Indices
{
    class Program
    {

        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            string array = Console.ReadLine();
            string[] arraySplit = array.Split();

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(arraySplit[i]);
            }

            List<int> outArr = new List<int>();
            outArr.Add(0);

            int startCycle = -1;
            int endCycle = -1;
            int index = 0;
            bool[] used = new bool[n];
            bool cycle = false;
            while (index <= n - 1 && index >= 0)
            {
                if (used[index])
                {
                    startCycle = index;
                    cycle = true;
                    break;
                }
                outArr.Add(arr[index]);
                used[index] = true;
                endCycle = index;
                index = arr[index];
            }
            StringBuilder output = new StringBuilder();
            if (cycle)
            {
                for (int i = 0; i < outArr.Count - 1; i++)
                {
                    if (i == startCycle && i == endCycle -1)
                    {
                        if (output.Length > 0 && output[output.Length - 1] == ' ')
                        {
                            output.Remove(output.Length - 1, 1);
                        }
                        output.Append("(");
                        output.Append(outArr[i].ToString());
                        output.Append(") ");

                    }
                    else if (i == startCycle - 1)
                    {
                        output.Append(outArr[i].ToString());
                    }
                    else if (i == startCycle)
                    {
                        if (output.Length > 0 && output[output.Length - 1] == ' ')
                        {
                            output.Remove(output.Length - 1, 1);
                        }
                        output.Append("(");
                        output.Append(outArr[i].ToString());
                        output.Append(" ");
                    }
                    else if (i == outArr.Count - 2)
                    {
                        output.Append(outArr[i].ToString());
                        output.Append(")");
                    }
                    else if (i < startCycle - 1 || i > startCycle)
                    {
                        output.Append(outArr[i].ToString());
                        output.Append(" ");
                    }
                }
                Console.WriteLine("{0}", output.ToString().Trim());
            }
            else
            {
                for (int i = 0; i < outArr.Count - 1; i++)
                {
                    if (i == outArr.Count - 2)
                    {
                        output.Append(outArr[i].ToString());
                    }
                    else
                    {
                        output.Append(outArr[i].ToString());
                        output.Append(" ");
                    }
                }
                Console.WriteLine("{0}", output.ToString().Trim());
            }
        }
    }
}
