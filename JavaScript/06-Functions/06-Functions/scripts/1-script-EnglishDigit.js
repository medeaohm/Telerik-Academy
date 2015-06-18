// Problem 1. English digit
//
// Write a function that returns the last digit of given integer as an English word.

var number = 1234;

console.log('Number: ' + number);
console.log('Last digit: ' + lastDigit(number));

function lastDigit(num) {
    var numberString = number.toString();
    lastD = numberString[numberString.length - 1];

    var result;
    switch (lastD) {
        case '0': result = 'zero'; break;
        case '1': result = 'one'; break;
        case '2': result = 'two'; break;
        case '3': result = 'three'; break;
        case '4': result = 'four'; break;
        case '5': result = 'five'; break;
        case '6': result = 'six'; break;
        case '7': result = 'seven'; break;
        case '8': result = 'eight'; break;
        case '9': result = 'nine'; break;
        default: result = 'invalid input'; break;
    }

    return result;
}