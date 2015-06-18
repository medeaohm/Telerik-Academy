// Problem 4. Third digit
//
// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

var number = 9999799;

var isSeven = Math.floor((number / 100) % 10) === 7;

console.log('Is the third digit of '+ number + ' 7? --> ' + isSeven);