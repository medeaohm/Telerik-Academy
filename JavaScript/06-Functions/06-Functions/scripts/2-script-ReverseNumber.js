// Problem 2. Reverse number
//
// Write a function that reverses the digits of given decimal number.

var number = 123.45;

console.log('Number: ' + number);
console.log('Reversed number: ' + reverseNumber(number));

function reverseNumber(num) {
    var numberString = number.toString();
    var result = [];
    for (var i = 0; i < numberString.length; i+=1) {
        result[numberString.length-i] = numberString[i];
    }

    return result.join('');
}