// Problem 2. Lexicographically comparison
//
// Write a script that compares two char arrays lexicographically (letter by letter).

var array1 = ['a', 'b', 'c', 'd', 'e', 'f', 'g'];
var array2 = ['a', 'c', 'b', 'h', 'r', 't', 'j'];

var areEqual;

if (array1.length !== array2.length) {
    areEqual = false;
}
else {
    for (var i = 0; i < array1.length; i++) {
        if (array1[i] != array2[i]) {
            areEqual = false;
            break;
        }
    }
}

console.log('Array1 = ' + array1.join(', '));
console.log('Array2 = ' + array2.join(', '));

if (areEqual) {
    console.log("The arrays are equal");
}
else {
    console.log("The arrays are not equal");
}
