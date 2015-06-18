// Problem 4. Sort 3 numbers
//
// Sort 3 real values in descending order.
// Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

var a = 5;
var b = 1;
var c = 2;

var smaller;
var medium;
var bigger;

if (a >= b) {
    if (b >= c) {
        bigger = a;
        medium = b;
        smaller = c;
    }
    else if (c > a) {
        bigger = c;
        medium = a;
        smaller = b;
    }
    else {
        bigger = a;
        medium = c;
        smaller = b;
    }
}
else {
    if (b >= c) {
        if (c >= a) {
            bigger = b;
            medium = c;
            smaller = a;
        }
        else {
            bigger = b;
            medium = a;
            smaller = c;
        }
    }
    else {
        bigger = c;
        medium = b;
        smaller = a;
    }
}


var result = 'In descending order: ' + bigger + ' ' + medium + ' ' + smaller;
console.log('a = ' + a);
console.log('b = ' + b);
console.log('c = ' + c);
console.log(result);
