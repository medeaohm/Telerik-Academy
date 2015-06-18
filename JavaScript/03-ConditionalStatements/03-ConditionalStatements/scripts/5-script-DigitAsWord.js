// Problem 5. Digit as word
//
// Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

var digit = 5;
var digitAsWord;

switch (digit) {
    case 0: digitAsWord = 'zero'; break;
    case 1: digitAsWord = 'one'; break;
    case 2: digitAsWord = 'two'; break;
    case 3: digitAsWord = 'three'; break;
    case 4: digitAsWord = 'four'; break;
    case 5: digitAsWord = 'five'; break;
    case 6: digitAsWord = 'six'; break;
    case 7: digitAsWord = 'seven'; break;
    case 8: digitAsWord = 'eight'; break;
    case 9: digitAsWord = 'nine'; break;
    default: digitAsWord = 'not a digit'; break;
}

console.log(digit + ' -> ' + digitAsWord);