// Problem 8. Number as words
//
// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var number = 501;

var hundreds = Math.floor(number / 100);
var tens = Math.floor((number - ((hundreds * 100))) / 10);
var unit = Math.floor((number - ((hundreds * 100) + (tens * 10))));

var unitW;
var tensW;
var hundredsW;

if (number > 999 | number < 0) {
    Console.WriteLine("Invalid number...");
}

else {
    if (number <= 9 | number > 19) {
        switch (unit) {
            case 0: unitW = "zero "; break;
            case 1: unitW = "one "; break;
            case 2: unitW = "two "; break;
            case 3: unitW = "three "; break;
            case 4: unitW = "four "; break;
            case 5: unitW = "five "; break;
            case 6: unitW = "six "; break;
            case 7: unitW = "seven "; break;
            case 8: unitW = "eight "; break;
            case 9: unitW = "nine "; break;
            default: unitW = ""; break;
        }
    }
    if (number > 9 & number <= 19) {
        switch (((tens * 10) + unit)) {
            case 10: tensW = "ten "; break;
            case 11: tensW = "eleven "; break;
            case 12: tensW = "twelve "; break;
            case 13: tensW = "thirteen "; break;
            case 14: tensW = "fourteen "; break;
            case 15: tensW = "fiveteen "; break;
            case 16: tensW = "sixteen "; break;
            case 17: tensW = "seventeen "; break;
            case 18: tensW = "eightteen "; break;
            case 19: tensW = "nineteen "; break;
            default: tensW = ""; break;
        }
    }
    if (number > 19) {
        switch (tens) {
            case 2: tensW = "twenty "; break;
            case 3: tensW = "thirty "; break;
            case 4: tensW = "fourty "; break;
            case 5: tensW = "fivety "; break;
            case 6: tensW = "sixty "; break;
            case 7: tensW = "seventy "; break;
            case 8: tensW = "eighty "; break;
            case 9: tensW = "ninety "; break;
            default: tensW = ""; break;
        }
    }
    if (number > 19) {
        switch (hundreds) {
            case 1: hundredsW = "one hundred and "; break;
            case 2: hundredsW = "two hundred and "; break;
            case 3: hundredsW = "three hundred and "; break;
            case 4: hundredsW = "four hundred and "; break;
            case 5: hundredsW = "five hundred and "; break;
            case 6: hundredsW = "six hundred and "; break;
            case 7: hundredsW = "seven hundred and "; break;
            case 8: hundredsW = "eight hundred and "; break;
            case 9: hundredsW = "nine hundred and "; break;
            default: hundredsW = ""; break;
        }
    }

    var numberW = hundredsW + tensW + unitW;
    console.log(number + ' = ' + numberW);
}