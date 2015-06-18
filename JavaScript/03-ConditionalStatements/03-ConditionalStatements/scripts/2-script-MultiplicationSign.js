// Problem 2. Multiplication Sign
//
// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators.

var a = -2;
var b = 4;
var c = 3;

var sign;

if (a === 0|| b === 0 || c === 0) {
    sign = 0;
}
else if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) || (c < 0 && b > 0 && a > 0) || (a < 0 && b < 0 && c < 0)) {
    sign = '-';
}
else {
    sign = '+';
}

var result = 'The sign of the product is ' + sign;
console.log('a = ' + a);
console.log('b = ' + b);
console.log('c = ' + c);
console.log(result);
