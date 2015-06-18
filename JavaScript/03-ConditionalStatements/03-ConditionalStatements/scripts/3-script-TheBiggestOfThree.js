// Problem 3. The biggest of Three
//
// Write a script that finds the biggest of three numbers.
// Use nested if statements.

var a = 5;
var b = 2;
var c = 2;

var bigger = a;

if (b > a) {
    if (b > c) {
        bigger = b;
    }
    else {
        bigger = c;
    }
}

if (c > a) {
    if (b > c) {
        bigger = b;
    }
    else {
        bigger = c;
    }
}

var result = 'The biggest number is ' + bigger;
console.log('a = ' + a);
console.log('b = ' + b);
console.log('c = ' + c);
console.log(result);