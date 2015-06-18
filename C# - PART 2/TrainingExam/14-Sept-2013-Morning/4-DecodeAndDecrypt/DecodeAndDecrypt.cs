using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecodeAndDecrypt
{
    static void Main()
    {
        string input = Console.ReadLine();
        var length = new StringBuilder();
        for (int i  = input.Length - 1; i  > 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                length.Append(input[i]);
            }
            else
            {
                break;
            }
        }
        var revLength = new StringBuilder();
        for (int i = length.Length-1; i >= 0; i--)
        {
            revLength.Append(length[i]);
        }

        int lengthChipter = int.Parse(revLength.ToString());

        string chipterTry = input.Substring(input.Length - lengthChipter -1, lengthChipter);
        string g = input.Substring(0, input.Length - length.Length);

        string chipter = null;
        string encriptedMessage = null;

        bool compressed = false;
        foreach (char ch in g)
        {
            if (char.IsDigit(ch))
            {
                compressed = true;
            }
            if (compressed)
            {
                break;
            }
        }
        var newInput = new StringBuilder();
        if (compressed)
        {
            var t = new StringBuilder();
            int times = 1;
            foreach (char ch in input) 
            {
                if (char.IsDigit(ch))
                {
                    t.Append(ch);
                }
                else
                {
                    
                    if (t.Length > 0)
                    {
                        times = int.Parse(t.ToString());
                        for (int i = 0; i < times; i++)
                        {
                            newInput.Append(ch);
                        } 
                    }
                    else
                    {
                        newInput.Append(ch);
                    }
                    t.Clear(); 
                }
            }
            chipter = newInput.ToString().Substring(newInput.Length - lengthChipter, lengthChipter);
            encriptedMessage = newInput.ToString().Substring(0, newInput.Length - lengthChipter);
        }
        else
        {
            chipter = input.Substring(input.Length - lengthChipter -length.Length, lengthChipter);
            encriptedMessage = input.ToString().Substring(0, input.Length - lengthChipter - length.Length);
        }
        //Console.WriteLine("\n");
        //Console.WriteLine(chipter);
        //Console.WriteLine("\n");
        //Console.WriteLine(lengthChipter);
        //Console.WriteLine(encriptedMessage);

        string message = Decrypt(encriptedMessage, chipter);
        Console.WriteLine(message);
    }

    private static string Decrypt(string encriptedMessage, string chipter)
    {
        var message = new StringBuilder();
        if (chipter.Length < encriptedMessage.Length)
        {
            for (int i = 0; i < encriptedMessage.Length; i++)
            {
                message.Append((char)((char)(encriptedMessage[i] - 65 ^ (chipter[i % chipter.Length] - 65)) + 'A'));
            } 
        }
        else if (chipter.Length > encriptedMessage.Length)
        {
            string nia = encriptedMessage.Clone().ToString();
            var gne = new StringBuilder();
            while (chipter.Length > 0)
            {
                if (chipter.Length >= nia.Length)
                {
                    for (int i = 0; i < nia.Length; i++)
                    {
                        char bla = (char)((char)(nia[i] - 65 ^ (chipter[i] - 65)) + 'A');
                        gne.Append(bla);

                    }
                    chipter = chipter.Substring(nia.Length);
                    nia = gne.ToString(); 
                }
                else
                {
                    for (int i = 0; i < chipter.Length; i++)
                    {
                        char bla = (char)((char)(nia[i] - 65 ^ (chipter[i] - 65)) + 'A');
                        gne.Replace(gne[i], bla,i,1);
                        nia = gne.ToString(); 
                    }
                    chipter = "";
                }
            }
            message.Append(nia);
        }
        else
        {
            for (int i = 0; i < chipter.Length; i++)
            {
                message.Append((char)((char)(encriptedMessage[i] - 65 ^ (chipter[i] - 65)) + 'A'));
            } 
        }
        return message.ToString();
    }
}

