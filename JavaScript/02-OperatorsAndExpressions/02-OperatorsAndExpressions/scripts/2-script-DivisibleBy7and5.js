// Problem 2. Divisible by 7 and 5
//
// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var number = 7;
var result;

if (!(number%5) && !(number%7)) {
    result = number + ' can be divided (without remainder) by 7 and 5 in the same time.';
}

else {
    result = number + ' CANNOT be divided (without remainder) by 7 and 5 in the same time.';
}

console.log(result);