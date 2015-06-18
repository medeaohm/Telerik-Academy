// Problem 1. Exchange if greater
//
// Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

var a = 5.5;
var b = 4.5;
var temp;

if (a > b) {
    temp = a;
    a = b;
    b = temp;
}

console.log(a + ' ' + b);