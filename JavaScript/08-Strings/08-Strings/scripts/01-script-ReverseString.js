// Problem 1. Reverse string
//
// Write a JavaScript function that reverses a string and returns it.

var string = 'sample';
var reversed = reverseString(string);

function reverseString(str){
    var reversed = [];
    for (var i = str.length - 1; i >= 0 ; i--) {
        reversed[str.length - 1 - i] = str[i];
    }
    return reversed.join('');
}

console.log('Original string: ' + string);
console.log('Reversed string: ' + reversed);