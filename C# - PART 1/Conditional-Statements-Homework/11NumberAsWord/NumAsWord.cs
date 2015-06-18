using System;

//### Problem 11.* Number as Words
//*	Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//_Examples:_

//| numbers | number as words               | 
//|---------|-------------------------------|-
//| 0       | Zero                          | 
//| 9       | Nine                          | 
//| 10      | Ten                           | 
//| 12      | Twelve                        | 
//| 19      | Nineteen                      | 
//| 25      | Twenty five                   | 
//| 98      | Ninety eight                  | 
//| 98      | Ninety eight                  | 
//| 273     | Two hundred and seventy three | 
//| 400     | Four hundred                  | 
//| 501     | Five hundred and one          | 
//| 617     | Six hundred and seventeen     | 
//| 711     | Seven hundred and eleven      | 
//| 999     | Nine hundred and ninety nine  |


class NumAsWord
    {
        static void Main()
        {
            Console.WriteLine("Please insert an integer number [0...999] ...");
            int number;
            bool valid = int.TryParse(Console.ReadLine(), out number);

            int hundreds = number / 100;
            int tens = (number - ((hundreds * 100))) / 10;
            int unit = (number - ((hundreds * 100) + (tens * 10)));

            string unitW = "";
            string tensW = "";
            string hundredsW = "";

            if (!valid | number > 999 | number < 0)
            {
                Console.WriteLine("Invalid number...");
            }
            
            else
            {
                if (number <= 9 | number > 19)
                {
                    switch (unit)
                    {
                        case 0: unitW = "zero ";    break;
                        case 1: unitW = "one ";     break;
                        case 2: unitW = "two ";     break;
                        case 3: unitW = "three ";   break;
                        case 4: unitW = "four ";    break;
                        case 5: unitW = "five ";    break;
                        case 6: unitW = "six ";     break;
                        case 7: unitW = "seven ";   break;
                        case 8: unitW = "eight ";   break;
                        case 9: unitW = "nine ";    break;
                        default: unitW = "";        break;
                    }
                }
                if (number > 9 & number <= 19)
                {
                    switch (((tens*10)+unit))
                    {
                        case 10: tensW = "ten ";            break;
                        case 11: tensW = "eleven ";         break;
                        case 12: tensW = "twelve ";         break;
                        case 13: tensW = "thirteen ";       break;
                        case 14: tensW = "fourteen ";       break;
                        case 15: tensW = "fiveteen ";       break;
                        case 16: tensW = "sixteen ";        break;
                        case 17: tensW = "seventeen ";      break;
                        case 18: tensW = "eightteen ";      break;
                        case 19: tensW = "nineteen ";       break;
                        default: tensW = "";                break;
                    }
                }
                if (number > 19)
                {
                    switch (tens)
                    {
                        case 2: tensW = "twenty ";      break;
                        case 3: tensW = "thirty ";      break;
                        case 4: tensW = "fourty ";      break;
                        case 5: tensW = "fivety ";      break;
                        case 6: tensW = "sixty ";       break;
                        case 7: tensW = "seventy ";     break;
                        case 8: tensW = "eighty ";      break;
                        case 9: tensW = "ninety ";      break;
                        default: tensW = "";            break;
                    }
                }
                if (number > 19)
                {
                    switch (hundreds)
                    {
                        case 1: hundredsW = "one hundred and ";     break;
                        case 2: hundredsW = "two hundred and ";     break;
                        case 3: hundredsW = "three hundred and ";   break;
                        case 4: hundredsW = "four hundred and ";    break;
                        case 5: hundredsW = "five hundred and ";    break;
                        case 6: hundredsW = "six hundred and ";     break;
                        case 7: hundredsW = "seven hundred and ";   break;
                        case 8: hundredsW = "eight hundred and ";   break;
                        case 9: hundredsW = "nine hundred and ";    break;
                        default: hundredsW = "";                    break;
                    }  
                }

                string numberW = hundredsW  + tensW  + unitW;
                Console.WriteLine(numberW);
            }
        }
    }

