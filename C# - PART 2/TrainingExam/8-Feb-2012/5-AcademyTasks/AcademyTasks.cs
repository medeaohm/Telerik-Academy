using System;
using System.Collections.Generic;
using System.Text;

class AcademyTasks
{
    static void Main()
    {
        var pleasentness = new List<ushort>();
        string input = Console.ReadLine();
        string[] inputSplit = input.Split(new char[]{' ',','}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string number in inputSplit)
        {
            pleasentness.Add(ushort.Parse(number));
        }
        ushort variety = ushort.Parse(Console.ReadLine());

        int res = pleasentness.Count;
        for (int i = 0; i < pleasentness.Count; i++)
        {
            
            for (int j = i+1; j < pleasentness.Count; j++)
            {
                int diff = Math.Abs(pleasentness[i] - pleasentness[j]);
                if (diff < variety)
                {
                    continue;
                }
                int act = (i + 3) / 2;
                int k = j - i;
                act += (k +1)/2;
                res = Math.Min(res, act);   
            }
        }
        Console.WriteLine(res);
    }
}

