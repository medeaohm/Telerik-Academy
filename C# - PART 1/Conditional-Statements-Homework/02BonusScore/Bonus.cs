using System;

//### Problem 2. Bonus Score
//*	Write a program that applies bonus score to given score in the range `[1…9]` by the following rules:
//    *	If the score is between `1` and `3`, the program multiplies it by `10`.
//    *	If the score is between `4` and `6`, the program multiplies it by `100`.
//    *	If the score is between `7` and `9`, the program multiplies it by `1000`.
//    *	If the score is `0` or more than `9`, the program prints `“invalid score”`.

//_Examples:_

//| score | result        |
//|-------|---------------|
//| 2     | 20            |
//| 4     | 400           |
//| 9     | 9000          |
//| -1    | invalid score |
//| 10    | invalid score |

class Bonus
{
    static void Main()
    {
        Console.WriteLine("Insert your row score (0-9) and I'll calculate your score with bonus  \n");
        int bonusScore = int.Parse(Console.ReadLine());
        switch (bonusScore)
        {
            case 1:
            case 2:
            case 3: Console.WriteLine(bonusScore * 10); break;
            case 4:
            case 5:
            case 6: Console.WriteLine(bonusScore * 100); break;
            case 7:
            case 8:
            case 9: Console.WriteLine(bonusScore * 1000); break;
            default: if ((bonusScore <= 0) || (bonusScore > 9))
                {
                    Console.WriteLine("invalid score"); ;
                }
                break;
        }
    }
}
        
       