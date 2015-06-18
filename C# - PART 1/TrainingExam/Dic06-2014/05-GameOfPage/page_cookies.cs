//Problem 5 – Game of Page

//Page is working in a bakery shop. She sells cookies. The best cookies! There are many customers and all of them seem to gather around her. It is no secret that she is single and all of them want to give their best shot and try to win her heart.
//You my friend are the same sucker as they are. You like the girl, now what you are going to do about it and all those mindless drones that call themselves your competition.
//Page has recently started to take programming lessons and since you are so ultra-professional in programming that might be a good entry point for building your strategy.
//After talking to Page she agrees to play a game of cookie bits with you. She seems excited, and so are you. She gives you the rules of a game that she came up with. Now, she cannot spend too much time with you, but you can still play the game as she sells you cookies. Otherwise her manager will give her trouble.
//Here are the rules of the game:
//Page is holding a square tray of cookies. Sometimes it is full of cookies, and sometimes there are just a few. There are also cookies that are broken and even single cookie crumbs here and there. You cannot buy broken cookies or crumbs - the only thing you can buy is a whole cookie. The whole cookie looks like this:
//111
//111
//111
//All other variations will be considered as broken. If there is a single one (1) and nothing around, it will be considered a crumb. The center of the cookie will be considered the second one (1) on the second row.
//How you play the game
//Page will show you her tray and she will start asking you questions. Her tray is a square one and it can be divided into 16 rows that have 16 cells in them. She will ask you for a specific location by first giving you an integer for the row, and then an integer for the col. If she asks you “what is” and in the location is the center of a cookie, you must say “cookie”. If it is not the center of a cookie, you must say either “broken cookie” or a “cookie crumb”. If she asks you to “buy” the location, you must buy it and she will give it to you. If there is something in the location, but it is not a cookie you must say “page”. If there is nothing in the location you must say “smile”. She can also ask you if you want to buy something on a given location. If it is a cookie, you must take it from the tray and later pay for it. If the given location is not empty, but is also not the center of a cookie you must say “page”.
//After the game is done, she will ask you to pay her for the cookies.
//The cost for each cookie is $1.79.
//Input
//On the first 16 lines you will receive the current tray lines as sequences of 1 and 0.
//Afterwards Page will start asking you questions. She can ask you three things. “what is” and “buy” will both be followed by two lines that state the location she asks you about. On the first line she will tell you the row, and on the second one – the column.
//The third thing she can ask you is “paypal”. This will end the game and you must pay her for the cookies that she gave you.
//Note
//It is possible for Page to cut a cookie, if it is too big.
//Output
//You must respond and print the corresponding answer for the questions that Page is asking you. These questions are going to be given a random number of times.
//On the last line you must pay Page, by printing your current check for the cookies.
//Constraints


using System;
using System.Collections.Generic;

public class page_cookies
{
    public static void Main()
    {
        char[,] matrix = new char[16, 16];
        List<string> answers = new List<string>();
        int cookies = 0;

        for (int rows = 0; rows < 16; rows++)
        {
            string digits = Console.ReadLine();
            for (int cols = 0; cols < digits.Length; cols++)
            {
                matrix[rows, cols] = digits[cols];
            }
        }

        while (true)
        {
            string question = Console.ReadLine();
            int cookiePiecesCount = 0;

            if (question == "paypal")
            {
                break;
            }

            if (question == "what is")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if ((col == 0 && row == 0) || (col == 0 && row == 15))
                {
                    if (matrix[row, col] == '1' && matrix[row, col + 1] == '1')
                    {
                        answers.Add("broken cookie");
                        continue;
                    }

                    if (matrix[row, col] == '1' && matrix[row, col + 1] == '0')
                    {
                        answers.Add("cookie crumb");
                        continue;
                    }
                }

                if ((col == 15 && row == 0) || (col == 15 && row == 15))
                {
                    if (matrix[row, col] == '1' && matrix[row, col - 1] == '1')
                    {
                        answers.Add("broken cookie");
                        continue;
                    }

                    if (matrix[row, col] == '1' && matrix[row, col - 1] == '0')
                    {
                        answers.Add("cookie crumb");
                        continue;
                    }
                }

                if (matrix[row, col] == '0')
                {
                    answers.Add("smile");
                    continue;
                }

                if (row == 0 || row == 15)
                {
                    if (matrix[row, col - 1] == '1' || matrix[row, col + 1] == '1')
                    {
                        answers.Add("broken cookie");
                    }

                    else if (matrix[row, col - 1] == '0' && matrix[row, col + 1] == '0')
                    {
                        answers.Add("cookie crumb");
                    }
                }
                else
                {
                    for (int i = row - 1; i <= row + 1; i++)
                    {
                        for (int j = col - 1; j <= col + 1; j++)
                        {
                            if (matrix[i, j] == '1')
                            {
                                cookiePiecesCount++;
                            }
                        }
                    }

                    if (cookiePiecesCount == 1)
                    {
                        answers.Add("cookie crumb");
                    }

                    if (cookiePiecesCount > 1 && cookiePiecesCount < 9)
                    {
                        answers.Add("broken cookie");
                    }

                    if (cookiePiecesCount == 9)
                    {
                        answers.Add("cookie");
                    }
                }
            }

            if (question == "buy")
            {
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                if (matrix[row, col] == '0')
                {
                    answers.Add("smile");
                }

                else
                {
                    if (row == 0 || row == 15)
                    {
                        answers.Add("page");
                    }

                    else
                    {
                        for (int i = row - 1; i <= row + 1; i++)
                        {
                            for (int j = col - 1; j <= col + 1; j++)
                            {
                                if (matrix[i, j] == '1')
                                {
                                    matrix[i, j] = '0';
                                    cookiePiecesCount++;
                                }
                            }
                        }

                        if (cookiePiecesCount < 9)
                        {
                            answers.Add("page");
                        }
                        if (cookiePiecesCount == 9)
                        {
                            cookies++;
                        }
                    }
                }
            }
        }

        for (int i = 0; i < answers.Count; i++)
        {
            Console.WriteLine(answers[i]);
        }

        Console.WriteLine("{0:F2}", cookies * 1.79);
    }

}