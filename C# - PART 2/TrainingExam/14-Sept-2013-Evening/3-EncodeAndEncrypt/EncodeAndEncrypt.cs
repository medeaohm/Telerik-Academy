using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class EncodeAndEncrypt
{
    static void Main()
    {
        string message = Console.ReadLine();
        string chipter = Console.ReadLine();

        string encoded = Encode(message, chipter);
        //Console.WriteLine(encoded);

        string encMessCh = encoded + chipter + chipter.Length.ToString();
        //Console.WriteLine(encMessCh);

        string finalOutput = RemoveMultipleChars(encMessCh);
        Console.WriteLine(finalOutput);
    }

    private static string RemoveMultipleChars(string message)
    {
          StringBuilder encodedTextBuilder = new StringBuilder(message.Length);
            int indexInMessage = 0;
            while (indexInMessage < message.Length)
            {
                char currentSymbol = message[indexInMessage];
                int scanIndex = indexInMessage + 1;
                int repeatLength = 1;
                while (scanIndex < message.Length &&
                    message[scanIndex] == currentSymbol)
                {
                    repeatLength++;
                    scanIndex++;
                }

                indexInMessage = scanIndex;
                if (repeatLength > 2)
                {
                    encodedTextBuilder.Append(repeatLength);
                    encodedTextBuilder.Append(currentSymbol);
                }
                else
                {
                    encodedTextBuilder.Append(new string(currentSymbol, repeatLength));
                }
            }
            return encodedTextBuilder.ToString();
    }

    private static string Encode(string message, string chipter)
    {
        var encMess = new StringBuilder();
        if (message.Length > chipter.Length)
        {
            for (int i = 0; i < message.Length; i++)
            {
                char c = (char)((char)((message[i] -65) ^ (chipter[i % chipter.Length] -65)) + 'A');
                encMess.Append(c);
            }
        }
        else if (message.Length < chipter.Length)
        {
            string nMess = message;
            string nchip = chipter;
            var str = new StringBuilder();
            while (chipter.Length > 0)
            {
                if (nchip.Length >= nMess.Length)
                {
                    for (int i = 0; i < nMess.Length; i++)
                    {
                        char c = (char)((char)((nMess[i] - 65) ^ (nchip[i] - 65)) + 'A');
                        str.Append(c);
                    }
                    nMess = str.ToString();
                    nchip = chipter.Substring(message.Length);
                }
                else
                {
                    for (int i = 0; i < nchip.Length; i++)
                    {
                        char c = (char)((char)((nMess[i] - 65) ^ (nchip[i] - 65)) + 'A');
                        str.Replace(nMess[i], c, i, 1);
                        nMess = str.ToString();
                    }
                    chipter = "";
                }
            }
            encMess.Append(nMess); 
        }
        else
        {
            for (int i = 0; i < message.Length; i++)
            {
                char c = (char)((char)((message[i] -65) ^ (chipter[i] - 65)) + 'A');
                encMess.Append(c);
            }
        }
        return encMess.ToString();
    }
}

