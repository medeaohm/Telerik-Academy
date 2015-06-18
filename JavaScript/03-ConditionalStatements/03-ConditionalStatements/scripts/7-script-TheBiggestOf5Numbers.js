// Problem 7. The biggest of five numbers
//
// Write a script that finds the greatest of given 5 variables.
// Use nested if statements.

var a = 5;
var b = 2;
var c = 2;
var d = 4;
var e = 1;

var bigger = a;

if (b > a & b > c & b > d & b > e) {
    bigger = b;
}
else if (c > a & c > b & c > d & c > e) {
    bigger = c;
}
else if (d > a & d > c & d > b & d > e) {
    bigger = d;
}
else if (e > a & e > b & e > c & e > d) {
    bigger = e;
}

var result = 'The biggest number is ' + bigger;
console.log('a = ' + a);
console.log('b = ' + b);
console.log('c = ' + c);
console.log('d = ' + d);
console.log('e = ' + e);
console.log(result);