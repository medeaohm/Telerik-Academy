using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MessagesInABottle
{
    class MessagesInABottle
    {
        static void Main()
        {
            //string message = Console.ReadLine();

            string code = Console.ReadLine();
            Dictionary<char,string> encode = new Dictionary<char, string>();
            int index = 0;
            while (!string.IsNullOrWhiteSpace(code))
            {
                StringBuilder value = new StringBuilder();
                
                for (int i = 1; i < code.Length; i++)
			    {
			        if (char.IsDigit(code,i))
	                {
		               value.Append(code.Substring(i,1));
                       index = i;
	                }
			    }

                encode.Add(code[0], value.ToString());
                code = code.Substring(index + 1);
            }
            foreach (var item in encode)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }
    }
}
